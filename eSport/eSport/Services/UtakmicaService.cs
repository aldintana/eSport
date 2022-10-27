using AutoMapper;
using eSport.Database;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eSport.Services
{
    public class UtakmicaService : BaseCRUDService<Model.Utakmica, UtakmicaSearchRequest, Database.Utakmica, UtakmicaInsertRequest, UtakmicaInsertRequest>, IUtakmicaService
    {
        public UtakmicaService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Utakmica> Get(UtakmicaSearchRequest search = null)
        {
            var entity = _context.Set<Database.Utakmica>().AsQueryable();

            if (search.DomacinId.HasValue)
            {
                entity = entity.Where(x => x.DomacinId == search.DomacinId);
            }

            if (search.GostId.HasValue)
            {
                entity = entity.Where(x => x.GostId == search.GostId);
            }

            if (search.TurnirId.HasValue)
            {
                entity = entity.Where(x => x.TurnirId == search.TurnirId);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Utakmica>>(list);
        }
    }
}
