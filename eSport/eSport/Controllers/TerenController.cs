using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    [Authorize]
    public class TerenController : BaseCRUDController<Model.Teren, TerenSearchRequest, TerenInsertRequest, TerenInsertRequest>
    {
        public TerenController(ITerenService terenService) : base(terenService)
        {
        }

        [Authorize(Roles = "Admin")]
        public override Teren Insert([FromBody] TerenInsertRequest request)
        {
            return base.Insert(request);
        }
        [Authorize(Roles = "Admin")]
        public override Teren Update(int id, [FromBody] TerenInsertRequest request)
        {
            return base.Update(id, request);
        }
    }
}
