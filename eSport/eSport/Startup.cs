using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Database;
using eSport.Filters;
using eSport.Security;
using eSport.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace eSport
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });
            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.CustomSchemaIds(type => type.ToString());

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));                   
            services.AddScoped<ISportService, SportService>();
            services.AddScoped<ITerenService, TerenService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<ITipRezervacijeService, TipRezervacijeService>();
            services.AddScoped<ICjenovnikService, CjenovnikService>();
            services.AddScoped<ITerminService, TerminService>();
            services.AddScoped<ITurnirService, TurnirService>();
            //services.AddControllers().AddNewtonsoftJson(x =>
            //        x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAuthentication("BasicAuthentication")
                    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("MyPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c=>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
                
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
