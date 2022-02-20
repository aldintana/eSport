using eSport.Database;
using eSport.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public interface ITerenService : ICRUDService<Model.Teren, TerenSearchRequest, TerenInsertRequest, TerenInsertRequest>
    {
    }
}
