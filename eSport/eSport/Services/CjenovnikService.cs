using AutoMapper;
using System.Linq;
using eSport.Model;
using eSport.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eSport.Services
{
    public class CjenovnikService : BaseCRUDService<Model.Cjenovnik, CjenovnikSearchRequest, Database.Cjenovnik, CjenovnikInsertRequest, CjenovnikInsertRequest>, ICjenovnikService
    {
        public CjenovnikService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Cjenovnik> Get(CjenovnikSearchRequest search = null)
        {
            var entity = _context.Set<Database.Cjenovnik>().AsQueryable();

            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

            if (search.TerenId.HasValue)
            {
                entity = entity.Where(x => x.TerenId == search.TerenId);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Cjenovnik>>(list);
        }
    }
}
