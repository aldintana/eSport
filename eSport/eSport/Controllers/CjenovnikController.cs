using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class CjenovnikController : BaseCRUDController<Model.Cjenovnik, CjenovnikSearchRequest, CjenovnikInsertRequest, CjenovnikInsertRequest>
    {
        public CjenovnikController(ICjenovnikService cjenovnikService) : base(cjenovnikService)
        {
        }
    }
}
