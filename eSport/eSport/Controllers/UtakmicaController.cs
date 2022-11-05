using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;

namespace eSport.Controllers
{
    [Authorize]
    public class UtakmicaController : BaseCRUDController<Model.Utakmica, UtakmicaSearchRequest, UtakmicaInsertRequest, UtakmicaInsertRequest>
    {
        public UtakmicaController(IUtakmicaService utakmicaService) : base(utakmicaService)
        {
        }
    }
}
