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

        public override Model.Turnir Insert(TurnirInsertRequest request)
        {
            if (IsZauzet(request))
                return null;
            var entity = _mapper.Map<Database.Turnir>(request);
            if (request.KorisnikId != null)
            {
                var korisnik = _context.Korisniks.FirstOrDefault(k => k.Id == request.KorisnikId);
                korisnik.Bodovi += 20;
                if (request.IsPopust)
                {
                    korisnik.Bodovi -= 40;
                }
                _context.Korisniks.Update(korisnik);
            }

            entity.CreatedAt = DateTime.Now;
            entity.IsDeleted = false;
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Turnir>(entity);
        }

        public override Model.Turnir Update(int id, TurnirInsertRequest request)
        {
            if (IsZauzet(request, id))
                return null;
            var entity = _context.Turnirs.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Turnir>(entity);
        }

        public bool GenerisiTurnir(int id)
        {
            var turnir = _context.Turnirs.FirstOrDefault(t => t.Id == id);
            if (turnir == null)
                return false;

            turnir.IsGenerisan = true;

            var timovi = _context.Tims.Where(t => t.TurnirId == id).ToList();

            if (timovi.Count() < 3)
                return false;

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

            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

            if (search.CjenovnikId.HasValue)
            {
                entity = entity.Where(x => x.CjenovnikId == search.CjenovnikId);
            }
            if (search.TerenId.HasValue)
            {
                entity = entity.Where(x => x.TerenId == search.TerenId);
            }
            if (search.SportId.HasValue)
            {
                entity = entity.Where(x => x.Teren.SportId == search.SportId);
            }
            if (search.KorisnikId.HasValue)
            {
                entity = entity.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if(search.IsPotvrdjen.HasValue)
            {
                entity = entity.Where(x => x.IsPotvrdjen == search.IsPotvrdjen);
            }

            if (search.OdDatuma.HasValue)
            {
                entity = entity.Where(x => x.DatumKraja >= search.OdDatuma);
            }

            if (search.DoDatuma.HasValue)
            {
                entity = entity.Where(x => x.DatumKraja <= search.DoDatuma);
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

        public override Model.Turnir Delete(int id, bool soft = true)
        {
            var entity = _context.Turnirs.Find(id);

            var timovi = _context.Tims.Where(x => x.TurnirId == id).ToList();
            var utakmice = _context.Utakmicas.Where(x => x.TurnirId == id).ToList();

            if (soft)
            {
                entity.IsDeleted = true;
                timovi.ForEach(x => x.IsDeleted = true);
                _context.Tims.UpdateRange(timovi);
                utakmice.ForEach(x => x.IsDeleted = true);
                _context.Utakmicas.UpdateRange(utakmice);
            }
            else
            {
                _context.Turnirs.Remove(entity);
                _context.Tims.RemoveRange(timovi);
                _context.Utakmicas.RemoveRange(utakmice);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Turnir>(entity);
        }

        public bool IsZauzet(TurnirInsertRequest request, int? id = null)
        {
            var entity = _context.Set<Database.Termin>().AsQueryable();
            entity = entity.Where(x => !x.IsDeleted && x.TerenId == request.TerenId 
                && request.DatumPocetka.Date <= x.Datum.Date && x.Datum.Date <= request.DatumKraja.Date && 
                ((x.Pocetak.Hour <= request.VrijemePocetka && request.VrijemePocetka < x.Kraj.Hour) || 
                (x.Pocetak.Hour < request.VrijemeKraja && request.VrijemeKraja <= x.Kraj.Hour)));
            if (entity != null && entity.Any())
            {       
                return true;
            }
            var turnirEntity = _context.Set<Database.Turnir>().AsQueryable();
            turnirEntity = turnirEntity.Where(x => !x.IsDeleted && x.TerenId == request.TerenId
                && ((x.DatumPocetka <= request.DatumPocetka && request.DatumPocetka <= x.DatumKraja)
                || (x.DatumPocetka <= request.DatumKraja && request.DatumKraja <= x.DatumKraja)
                || (request.DatumPocetka <= x.DatumPocetka && x.DatumPocetka <= request.DatumKraja)
                || (request.DatumPocetka <= x.DatumKraja && x.DatumKraja <= request.DatumKraja))
                && ((x.VrijemePocetka <= request.VrijemePocetka && request.VrijemePocetka < x.VrijemeKraja)
                || (x.VrijemePocetka < request.VrijemeKraja && request.VrijemeKraja <= x.VrijemeKraja)
                || (request.VrijemePocetka <= x.VrijemePocetka && x.VrijemePocetka < request.VrijemeKraja)
                || (request.VrijemePocetka <= x.VrijemeKraja && x.VrijemeKraja < request.VrijemeKraja)));
            if (turnirEntity != null && turnirEntity.Any())
            {
                if (id != null && turnirEntity.FirstOrDefault(x => x.Id == id.GetValueOrDefault()) != null)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
