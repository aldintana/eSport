using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    public class TurnirController : BaseCRUDController<Model.Turnir, TurnirSearchRequest, TurnirInsertRequest, TurnirInsertRequest>
    {
        private ITurnirService _turnirService;
        public TurnirController(ITurnirService turnirService) : base(turnirService)
        {
            _turnirService = turnirService;
        }
        [HttpPut("generisiTurnir/{id}")]
        public bool GenerisiTurnir(int id)
        {
            return _turnirService.GenerisiTurnir(id);
        }
    }
}
