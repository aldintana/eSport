using System;
using System.Collections.Generic;
using System.Text;

namespace eSport.Model
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        public int Bodovi { get; set; }
    }
}
