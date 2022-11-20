using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class TipRezervacijeController : BaseReadController<TipRezervacije, object>
    {
        public TipRezervacijeController(ITipRezervacijeService service) : base(service)
        {

        }
    }
}
