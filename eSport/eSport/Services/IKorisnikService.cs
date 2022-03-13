using eSport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public interface IKorisnikService : ICRUDService<Korisnik, BaseSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest>
    {
        Task<Korisnik> Login(string korisnickoIme, string lozinka);
    }
}
