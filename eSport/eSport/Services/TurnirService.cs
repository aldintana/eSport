using AutoMapper;
using eSport.Database;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSport.Services
{
    public class TurnirService : BaseCRUDService<Model.Turnir, TurnirSearchRequest, Database.Turnir, TurnirInsertRequest, TurnirInsertRequest>, ITurnirService
    {
        public TurnirService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }

        public bool GenerisiTurnir(int id)
        {
            var turnir = _context.Turnirs.FirstOrDefault(t => t.Id == id);
            if (turnir == null)
                return false;

            turnir.IsGenerisan = true;

            var timovi = _context.Tims.Where(t => t.TurnirId == id).ToList();

            var utakmice = new List<Database.Utakmica>();

            for (int i = 0; i < timovi.Count; i++)
            {
                for (int j = 0; j < timovi.Count; j++)
                {
                    if (i != j && i < j)
                    {
                        var utakmica = new Database.Utakmica
                        {
                            DomacinId = timovi[i].Id,
                            GostId = timovi[j].Id,
                            TurnirId = id,
                            BrojGolovaDomacina = 0,
                            BrojGolovaGosta = 0,
                            IsZavrsena = false,
                            VrijemeUtakmice = DateTime.Now
                        };
                        utakmice.Add(utakmica);
                    }
                }
            }

            _context.Utakmicas.AddRange(utakmice);

            _context.SaveChanges();

            return true;
        }

        public override IEnumerable<Model.Turnir> Get(TurnirSearchRequest search = null)
        {
            var entity = _context.Set<Database.Turnir>().AsQueryable();

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

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Turnir>>(list);
        }

        public bool IsZauzet(TerminInsertRequest request, int? id = null)
        {
            var entity = _context.Set<Database.Termin>().AsQueryable();
            entity = entity.Where(x => x.TerenId == request.TerenId && ((x.Pocetak <= request.Pocetak && request.Pocetak < x.Kraj) || (x.Pocetak < request.Kraj && request.Kraj <= x.Kraj)));
            if (entity != null && entity.Any() && (id != null && entity.FirstOrDefault(x => x.Id == id.GetValueOrDefault()) == null))
                return true;
            return false;
        }
    }
}
