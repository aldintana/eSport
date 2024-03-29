﻿using AutoMapper;
using eSport.Database;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eSport.Services
{
    public class TimService : BaseCRUDService<Model.Tim, TimSearchRequest, Database.Tim, TimInsertRequest, TimInsertRequest>, ITimService
    {
        public TimService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Tim> Get(TimSearchRequest search = null)
        {
            var entity = _context.Set<Database.Tim>().AsQueryable();

            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search.TekstPretraga))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.TekstPretraga));
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

            entity = entity.OrderByDescending(x => x.BrojBodova).ThenByDescending(x => x.BrojDatihGolova);

            var list = entity.ToList();

            return _mapper.Map<List<Model.Tim>>(list);
        }
    }
}
