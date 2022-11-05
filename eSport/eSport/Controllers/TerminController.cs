using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>
    {
        public TerminController(ITerminService terminService) : base(terminService)
        {
        }
    }
}
