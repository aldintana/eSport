using AutoMapper;
using eSport.Database;
using eSport.Filters;
using eSport.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Model.BaseSearchRequest, Database.Korisnik, Model.KorisnikInsertRequest, Model.KorisnikInsertRequest>, IKorisnikService
    {
        public KorisnikService(DatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Korisnik> Get(BaseSearchRequest search = null)
        {
            var entity = _context.Set<Database.Korisnik>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.TekstPretraga))
            {
                entity = entity.Where(x => x.Ime.Contains(search.TekstPretraga)
                 || x.Prezime.Contains(search.TekstPretraga)
                 || x.KorisnickoIme.Contains(search.TekstPretraga));
            }

            if(search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var users = _context.Set<Database.Korisnik>().AsQueryable();
            if (users.Any(x => x.KorisnickoIme == request.KorisnickoIme))
            {
                return null;
            }
            var entity = _mapper.Map<Database.Korisnik>(request);
            _context.Add(entity);
            if (request.Lozinka != request.LozinkaProvjera)
            {
                throw new UserException("Lozinka nije ispravna");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            _context.SaveChanges();

            foreach (var role in request.Ulogas)
            {
                Database.KorisnikUloga korisnikUlogas = new Database.KorisnikUloga
                {
                    KorisnikId = entity.Id,
                    UlogaId = role
                };

                _context.KorisnikUlogas.Add(korisnikUlogas);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public override Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            var entity = _context.Korisniks.Include(x => x.KorisnikUlogas).FirstOrDefault(x => x.Id == id);
            var stariLozinkaHash = entity.LozinkaHash;
            var stariLozinkaSalt = entity.LozinkaSalt;
            _mapper.Map(request, entity);
            if (string.IsNullOrEmpty(request.Lozinka))
            {
                entity.LozinkaSalt = stariLozinkaSalt;
                entity.LozinkaHash = stariLozinkaHash;
            }
            else
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }
            _context.Korisniks.Update(entity);

            var korisnikUlogaIdsToRemove = entity.KorisnikUlogas.Select(x => x.UlogaId).Except(request.Ulogas).ToList();
            var korisnikUlogaToRemove = entity.KorisnikUlogas.Where(x => korisnikUlogaIdsToRemove.Any(y => y == x.UlogaId)).ToList();

            var korisnikUlogaIdsToInsert = request.Ulogas.Except(entity.KorisnikUlogas.Select(x => x.UlogaId));
            foreach (var uloga in korisnikUlogaIdsToInsert)
            {
                Database.KorisnikUloga korisnikUlogas = new Database.KorisnikUloga
                {
                    KorisnikId = entity.Id,
                    UlogaId = uloga
                };

                _context.KorisnikUlogas.Add(korisnikUlogas);
            }
            _context.KorisnikUlogas.RemoveRange(korisnikUlogaToRemove);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public async Task<Model.Korisnik> Login(string korisnickoIme, string lozinka)
        {
            var entity = await _context.Korisniks.Include("KorisnikUlogas.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == korisnickoIme);

            if (entity == null)
            {
                throw new UserException("Kredencijali nisu ispravni");
            }

            var hash = GenerateHash(entity.LozinkaSalt, lozinka);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Kredencijali nisu ispravni");
            }
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
