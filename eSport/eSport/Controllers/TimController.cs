using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class TimController : BaseCRUDController<Model.Tim, TimSearchRequest, TimInsertRequest, TimInsertRequest>
    {
        public TimController(ITimService timService) : base(timService)
        {
        }
    }
}
