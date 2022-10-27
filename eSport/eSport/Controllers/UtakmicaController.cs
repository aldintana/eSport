using eSport.Model;
using eSport.Services;

namespace eSport.Controllers
{
    public class UtakmicaController : BaseCRUDController<Model.Utakmica, UtakmicaSearchRequest, UtakmicaInsertRequest, UtakmicaInsertRequest>
    {
        public UtakmicaController(IUtakmicaService utakmicaService) : base(utakmicaService)
        {
        }
    }
}
