using eSport.Model;
using eSport.Services;

namespace eSport.Controllers
{
    public class TimController : BaseCRUDController<Model.Tim, TimSearchRequest, TimInsertRequest, TimInsertRequest>
    {
        public TimController(ITimService timService) : base(timService)
        {
        }
    }
}
