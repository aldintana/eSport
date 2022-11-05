using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class SportController : BaseCRUDController<Model.Sport, object, SportInsertRequest, SportInsertRequest>
    {
        public SportController(ISportService service) : base(service)
        {
            
        }

    }
}
