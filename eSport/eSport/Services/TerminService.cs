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
    public class TerminService : BaseCRUDService<Model.Termin, TerminSearchRequest, Database.Termin, TerminInsertRequest, TerminInsertRequest>, ITerminService
    {
        public TerminService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Termin> Get(TerminSearchRequest search = null)
        {
            var entity = _context.Set<Database.Termin>().AsQueryable();

            if (search.CjenovnikId.HasValue)
            {
                entity = entity.Where(x => x.CjenovnikId == search.CjenovnikId);
            }
            if (search.TerenId.HasValue)
            {
                entity = entity.Where(x => x.TerenId == search.TerenId);
            }
            if (search.KorisnikId.HasValue)
            {
                entity = entity.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if(search.IsPotvrdjen.HasValue)
            {
                entity = entity.Where(x => x.IsPotvrdjen == search.IsPotvrdjen);
            }
            if(search.Pocetak.HasValue)
            {
                entity = entity.Where(x => x.Pocetak.TimeOfDay == search.Pocetak.Value.TimeOfDay);
            }
            if (search.Kraj.HasValue)
            {
                entity = entity.Where(x => x.Kraj.TimeOfDay == search.Kraj.Value.TimeOfDay);
            }
            if (search.Datum.HasValue)
            {
                entity = entity.Where(x => x.Datum.Date == search.Datum.Value.Date);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Termin>>(list);
        }
    }
}
