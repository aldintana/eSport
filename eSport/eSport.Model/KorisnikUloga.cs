using System;
using System.Collections.Generic;
using System.Text;

namespace eSport.Model
{
    public class KorisnikUloga
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int UlogaId { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
