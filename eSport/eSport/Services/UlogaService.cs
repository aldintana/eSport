using AutoMapper;
using eSport.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class UlogaService : BaseReadService<Model.Uloga, Database.Uloga, object>, IUlogaService
    {
        public UlogaService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
    }
}
