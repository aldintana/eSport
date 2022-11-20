using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class UlogaController : BaseReadController<Uloga, object>
    {
        public UlogaController(IUlogaService service) : base(service)
        {

        }
    }
}
