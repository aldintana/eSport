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
    public class TipRezervacijeController : BaseReadController<TipRezervacije, object>
    {
        public TipRezervacijeController(ITipRezervacijeService service) : base(service)
        {

        }

        [AllowAnonymous]
        public override IEnumerable<TipRezervacije> Get([FromQuery] object search)
        {
            return base.Get(search);
        }
    }
}
