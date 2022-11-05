using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
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
