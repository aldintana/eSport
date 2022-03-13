using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace eSport.Database
{
    [Index(nameof(KorisnickoIme), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Korisnik : TEntity<Korisnik>
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
