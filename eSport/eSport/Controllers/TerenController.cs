using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class TerenController : BaseCRUDController<Model.Teren, TerenSearchRequest, TerenInsertRequest, TerenInsertRequest>
    {
        public TerenController(ITerenService terenService) : base(terenService)
        {
        }
    }
}
