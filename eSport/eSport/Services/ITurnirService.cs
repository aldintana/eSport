using eSport.Model;

namespace eSport.Services
{
    public interface ITurnirService : ICRUDService<Model.Turnir, TurnirSearchRequest, TurnirInsertRequest, TurnirInsertRequest>
    {
    }
}
