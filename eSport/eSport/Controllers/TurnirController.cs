using eSport.Model;
using eSport.Services;

namespace eSport.Controllers
{
    public class TurnirController : BaseCRUDController<Model.Turnir, TurnirSearchRequest, TurnirInsertRequest, TurnirInsertRequest>
    {
        public TurnirController(ITurnirService turnirService) : base(turnirService)
        {
        }
    }
}
