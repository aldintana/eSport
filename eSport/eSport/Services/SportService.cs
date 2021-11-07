using eSport.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class SportService : ISportService
    {
        public DatabaseContext _context { get; set; }
        public SportService(DatabaseContext context)
        {
            _context = context;
        }
        public List<Model.Sport> Get()
        {
            return new List<Model.Sport>();
        }
    }
}
