using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Database
{
    public class KorisnikUloga : TEntity<KorisnikUloga>
    {
        public int KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int UlogaId { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
