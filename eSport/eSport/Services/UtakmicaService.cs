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

            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

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

            if (search.IsZavrsena.HasValue)
            {
                entity = entity.Where(x => x.IsZavrsena == search.IsZavrsena);
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

        public override Model.Utakmica Update(int id, UtakmicaInsertRequest request)
        {
            var entity = _context.Utakmicas.Find(id);

            if (entity == null) 
                return null;

            if(request.IsZavrsena && !entity.IsZavrsena)
            {
                List<Database.Tim> timovi = new List<Database.Tim>();
                var domacin = _context.Tims.Find(request.DomacinId);
                var gost = _context.Tims.Find(request.GostId);
                domacin.BrojDatihGolova += request.BrojGolovaDomacina;
                domacin.BrojPrimljenihGolova += request.BrojGolovaGosta;
                gost.BrojDatihGolova += request.BrojGolovaGosta;
                gost.BrojPrimljenihGolova += request.BrojGolovaDomacina;
                if(request.BrojGolovaDomacina > request.BrojGolovaGosta)
                {
                    domacin.BrojPobjeda++;
                    domacin.BrojBodova += 3;
                    gost.BrojPoraza++;
                }
                else if(request.BrojGolovaDomacina == request.BrojGolovaGosta)
                {
                    domacin.BrojNerijesenih++;
                    domacin.BrojBodova++;
                    gost.BrojNerijesenih++;
                    gost.BrojBodova++;
                }
                else
                {
                    domacin.BrojPoraza++;
                    gost.BrojPobjeda++;
                    gost.BrojBodova += 3;
                }
                timovi.AddRange(new List<Database.Tim>() { domacin, gost });
                _context.UpdateRange(timovi);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Utakmica>(entity);
        }
    }
}
