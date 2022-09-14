using eSport.Model;
using eSport.Services;

namespace eSport.Controllers
{
    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>
    {
        public TerminController(ITerminService terminService) : base(terminService)
        {
        }
    }
}
