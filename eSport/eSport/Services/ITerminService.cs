using eSport.Model;

namespace eSport.Services
{
    public interface ITerminService : ICRUDService<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>
    {
    }
}
