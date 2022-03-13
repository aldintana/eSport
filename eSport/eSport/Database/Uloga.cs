using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Database
{
    public class Uloga : TEntity<Uloga>
    {
        public string Naziv { get; set; }
    }
}
