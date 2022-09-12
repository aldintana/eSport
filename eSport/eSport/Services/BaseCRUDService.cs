using AutoMapper;
using eSport.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class BaseCRUDService<T, TSearch, TDb, TInsert, TUpdate> : BaseReadService<T,TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TInsert : class where TUpdate : class where TDb:TEntity<TDb>
    {
        public BaseCRUDService(DatabaseContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public virtual T Insert(TInsert request)
        {
            var set = _context.Set<TDb>();
           
            TDb entity = _mapper.Map<TDb>(request);
            entity.CreatedAt = DateTime.Now;
            entity.IsDeleted = false;
            set.Add(entity);
            
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set = _context.Set<TDb>();
            var entity = set.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual T Delete(int id, bool soft = true)
        {
            var set = _context.Set<TDb>();

            var entity = set.Find(id);

            if(soft)
            {
                entity.IsDeleted = true;
            }
            else
            {
                set.Remove(entity);
            }

            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
