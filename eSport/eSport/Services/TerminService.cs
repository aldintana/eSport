﻿using System;
using AutoMapper;
using System.Linq;
using eSport.Model;
using eSport.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
            if (search.OdDatuma.HasValue)
            {
                entity = entity.Where(x => x.Datum.Date >= search.OdDatuma.Value.Date);
            }
            if (search.DoDatuma.HasValue)
            {
                entity = entity.Where(x => x.Datum.Date <= search.DoDatuma.Value.Date);
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

        public override Model.Termin Insert(TerminInsertRequest request)
        {
            if (IsZauzet(request))
                return null;
            var entity = _mapper.Map<Database.Termin>(request);
            if (request.KorisnikId != null)
            {
                var korisnik = _context.Korisniks.FirstOrDefault(k=>k.Id == request.KorisnikId);
                korisnik.Bodovi += 10;
                if(request.IsPopust)
                {
                    korisnik.Bodovi -= 30;
                }
                _context.Korisniks.Update(korisnik);
            }
            entity.CreatedAt = DateTime.Now;
            entity.IsDeleted = false;
            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Termin>(entity);
        }

        public override Model.Termin Update(int id, TerminInsertRequest request)
        {
            if (IsZauzet(request, id))
                return null;
            var entity = _context.Termins.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Termin>(entity);
        }

        public bool IsZauzet(TerminInsertRequest request, int? id = null)
        {
            var entity = _context.Set<Database.Termin>().AsQueryable();
            entity = entity.Where(x => !x.IsDeleted && x.TerenId == request.TerenId && x.Datum.Date == request.Datum.Date && 
                ((x.Pocetak <= request.Pocetak && request.Pocetak < x.Kraj) 
                || (x.Pocetak < request.Kraj && request.Kraj <= x.Kraj)));
            if (entity != null && entity.Any())
            {
                if (id != null && entity.FirstOrDefault(x => x.Id == id.GetValueOrDefault()) != null)
                {
                    return false;
                }
                return true;
            }
            var turnirEntity = _context.Set<Database.Turnir>().AsQueryable();
                turnirEntity = turnirEntity.Where(x => !x.IsDeleted && x.TerenId == request.TerenId 
                && x.DatumPocetka <= request.Datum && request.Datum <= x.DatumKraja && 
                ((x.VrijemePocetka <= request.Pocetak.Hour && request.Pocetak.Hour < x.VrijemeKraja)
                || (x.VrijemePocetka < request.Kraj.Hour && request.Kraj.Hour <= x.VrijemeKraja)));
            if (turnirEntity != null && turnirEntity.Any())
            {
                return true;
            }
            return false;
        }
    }
}
