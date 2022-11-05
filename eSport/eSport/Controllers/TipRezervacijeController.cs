using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
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
