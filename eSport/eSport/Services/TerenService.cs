using AutoMapper;
using eSport.Database;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class TerenService : BaseCRUDService<Model.Teren, TerenSearchRequest, Database.Teren, TerenInsertRequest, TerenInsertRequest>, ITerenService
    {
        public TerenService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Teren> Get(TerenSearchRequest search = null)
        {
            var entity = _context.Set<Database.Teren>().AsQueryable();
            
            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search.TekstPretraga))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.TekstPretraga));
            }

            if (search.SportId.HasValue)
            {
                entity = entity.Where(x => x.SportId == search.SportId);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Teren>>(list);
        }
    }
}
