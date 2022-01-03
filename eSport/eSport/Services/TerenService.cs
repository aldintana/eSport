using AutoMapper;
using eSport.Database;
using eSport.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class TerenService : BaseCRUDService<Model.Teren, object, Teren, TerenInsertRequest, TerenInsertRequest>, ITerenService
    {
        public TerenService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
    }
}
