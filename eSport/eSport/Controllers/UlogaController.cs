using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    public class UlogaController : BaseReadController<Uloga, object>
    {
        public UlogaController(IUlogaService service) : base(service)
        {

        }

        [AllowAnonymous]
        public override IEnumerable<Uloga> Get([FromQuery] object search)
        {
            return base.Get(search);
        }
    }
}
