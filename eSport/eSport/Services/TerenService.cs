using AutoMapper;
using eSport.Database;
using eSport.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class TerenService : BaseCRUDService<Model.Teren, TerenSearchRequest, Teren, TerenInsertRequest, TerenInsertRequest>, ITerenService
    {
        public TerenService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Teren> Get(TerenSearchRequest search = null)
        {
            var entity = _context.Set<Teren>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Teren>>(list);
        }
    }
}
