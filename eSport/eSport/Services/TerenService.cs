using AutoMapper;
using eSport.Database;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (search.KorisnikId.HasValue)
                return TerenRecommenderSystem(entity, search.KorisnikId.GetValueOrDefault());

            var list = entity.ToList();

            return _mapper.Map<List<Model.Teren>>(list);
        }

        public IEnumerable<Model.Teren> TerenRecommenderSystem(IQueryable<Database.Teren> entity, int korisnikId)
        {
            //dohvatiti termine za usera
            var termini = _context.Termins.Include(x => x.Teren).ThenInclude(x=>x.Sport).Where(x => x.KorisnikId == korisnikId).ToList();
            //prebrojati terene po sportu
            var sportTereni = termini.GroupBy(x => (x.Teren.SportId)).Select(
               x => new
               {
                   SportId = x.Key,
                   TerenCount = x.Count()
               }).OrderByDescending(x=>x.TerenCount).ToList();

            var terenList = new List<Tuple<Database.Teren, int>>();
            foreach (var item in entity)
            {
                //naci sport za teren
                var sport = sportTereni.FirstOrDefault(x => x.SportId == item.SportId)?.TerenCount ?? 0;
                //dodati teren, te broj koliko puta se taj sport koristio
                terenList.Add(Tuple.Create(item, sport));
            }
            terenList = terenList.OrderByDescending(x => x.Item2).ToList();
            var orderedList = terenList.Select(x => x.Item1);
            return _mapper.Map<List<Model.Teren>>(orderedList);
        }
    }
}
