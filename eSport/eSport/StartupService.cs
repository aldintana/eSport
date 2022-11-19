using System;
using eSport.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eSport
{
    public class StartupService
    {
        public void Init(DatabaseContext context)
        {
            context.Database.Migrate();

            #region ULOGE

            if (!context.Ulogas.Any(x => x.Naziv == "Admin"))
            {
                context.Ulogas.Add(new Uloga { Naziv = "Admin" });
            }
            if (!context.Ulogas.Any(x => x.Naziv == "Klijent"))
            {
                context.Ulogas.Add(new Uloga { Naziv = "Klijent" });
            }
            context.SaveChanges();

            #endregion ULOGE

            #region KORISNICI

            var adminUlogaId = context.Ulogas.First(x => x.Naziv == "Admin").Id;
            var klijentUlogaId = context.Ulogas.First(x => x.Naziv == "Klijent").Id;

            if (!context.Korisniks.Any(x => x.KorisnickoIme == "Admin"))
            {
                context.Korisniks.Add(new Korisnik
                {
                    Ime = "Admin",
                    Prezime = "Admin",
                    Email = "admin@gmail.com",
                    BrojTelefona = "061-111-222",
                    KorisnickoIme = "Admin",
                    LozinkaHash = "/XA9suDIPV1QqU3Yf9a0C0GvE30=",
                    LozinkaSalt = "iWkz60oc+7XTckmDkaLGjA==",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Korisniks.Any(x => x.KorisnickoIme == "Klijent"))
            {
                context.Korisniks.Add(new Korisnik
                {
                    Ime = "Klijent",
                    Prezime = "Klijent",
                    Email = "klijent@gmail.com",
                    BrojTelefona = "061-222-333",
                    KorisnickoIme = "Klijent",
                    LozinkaHash = "/XA9suDIPV1QqU3Yf9a0C0GvE30=",
                    LozinkaSalt = "iWkz60oc+7XTckmDkaLGjA==",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            context.SaveChanges();

            #endregion KORISNICI

            #region KORISNIKULOGAS

            var adminKorisnikId = context.Korisniks.First(x => x.KorisnickoIme == "Admin").Id;
            var klijentKorisnikId = context.Korisniks.First(x => x.KorisnickoIme == "Klijent").Id;

            if (!context.KorisnikUlogas.Any(x => x.KorisnikId == adminKorisnikId && x.UlogaId == adminUlogaId))
            {
                context.KorisnikUlogas.Add(new KorisnikUloga
                {
                    KorisnikId = adminKorisnikId,
                    UlogaId = adminUlogaId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.KorisnikUlogas.Any(x => x.KorisnikId == klijentKorisnikId && x.UlogaId == klijentUlogaId))
            {
                context.KorisnikUlogas.Add(new KorisnikUloga
                {
                    KorisnikId = klijentKorisnikId,
                    UlogaId = klijentUlogaId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            context.SaveChanges();

            #endregion KORISNIKULOGAS

            #region SPORT

            if (!context.Sports.Any(x => x.Naziv == "Fudbal"))
            {
                context.Sports.Add(new Sport
                {
                    Naziv = "Fudbal"
                });
                context.SaveChanges();
            }
            if (!context.Sports.Any(x => x.Naziv == "Tenis"))
            {
                context.Sports.Add(new Sport
                {
                    Naziv = "Tenis"
                });
            }
            if (!context.Sports.Any(x => x.Naziv == "Kosarka"))
            {
                context.Sports.Add(new Sport
                {
                    Naziv = "Kosarka"
                });
            }
            context.SaveChanges();

            var fudbalId = context.Sports.First(x => x.Naziv == "Fudbal").Id;
            var tenisId = context.Sports.First(x => x.Naziv == "Tenis").Id;
            var kosarkaId = context.Sports.First(x => x.Naziv == "Kosarka").Id;

            #endregion SPORT

            #region TIPREZERVACIJE

            if (!context.TipRezervacijes.Any(x => x.Naziv == "Dnevna"))
            {
                context.TipRezervacijes.Add(new TipRezervacije
                {
                    Naziv = "Dnevna",
                    IsDnevna = true,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });
            }
            if (!context.TipRezervacijes.Any(x => x.Naziv == "Satna"))
            {
                context.TipRezervacijes.Add(new TipRezervacije
                {
                    Naziv = "Satna",
                    IsDnevna = false,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });
            }
            context.SaveChanges();

            var dnevnaId = context.TipRezervacijes.First(x => x.Naziv == "Dnevna").Id;
            var satnaId = context.TipRezervacijes.First(x => x.Naziv == "Satna").Id;

            #endregion TIPREZERVACIJE

            #region TEREN

            if (!context.Terens.Any(x => x.Naziv == "Fudbalski teren 1"))
            {
                context.Terens.Add(new Teren
                {
                    Naziv = "Fudbalski teren 1",
                    SportId = fudbalId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Terens.Any(x => x.Naziv == "Fudbalski teren 2"))
            {
                context.Terens.Add(new Teren
                {
                    Naziv = "Fudbalski teren 2",
                    SportId = fudbalId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Terens.Any(x => x.Naziv == "Teniski teren 1"))
            {
                context.Terens.Add(new Teren
                {
                    Naziv = "Teniski teren 1",
                    SportId = tenisId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Terens.Any(x => x.Naziv == "Kosarkaski teren 1"))
            {
                context.Terens.Add(new Teren
                {
                    Naziv = "Kosarkaski teren 1",
                    SportId = kosarkaId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            context.SaveChanges();
            var fudbalskiTeren1Id = context.Terens.First(x => x.Naziv == "Fudbalski teren 1").Id;
            var fudbalskiTeren2Id = context.Terens.First(x => x.Naziv == "Fudbalski teren 2").Id;
            var kosarkaskiTeren1Id = context.Terens.First(x => x.Naziv == "Kosarkaski teren 1").Id;
            var teniskiTeren1Id = context.Terens.First(x => x.Naziv == "Teniski teren 1").Id;

            #endregion TEREN

            #region CJENOVNIKS

            if (!context.Cjenovniks.Any(x => x.TerenId == fudbalskiTeren1Id && x.TipRezervacijeId == dnevnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = fudbalskiTeren1Id,
                    TipRezervacijeId = dnevnaId,
                    Cijena = 200,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == fudbalskiTeren1Id && x.TipRezervacijeId == satnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = fudbalskiTeren1Id,
                    TipRezervacijeId = satnaId,
                    Cijena = 30,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == fudbalskiTeren2Id && x.TipRezervacijeId == dnevnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = fudbalskiTeren2Id,
                    TipRezervacijeId = dnevnaId,
                    Cijena = 200,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == fudbalskiTeren2Id && x.TipRezervacijeId == satnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = fudbalskiTeren2Id,
                    TipRezervacijeId = satnaId,
                    Cijena = 30,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == kosarkaskiTeren1Id && x.TipRezervacijeId == dnevnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = kosarkaskiTeren1Id,
                    TipRezervacijeId = dnevnaId,
                    Cijena = 200,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == kosarkaskiTeren1Id && x.TipRezervacijeId == satnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = kosarkaskiTeren1Id,
                    TipRezervacijeId = satnaId,
                    Cijena = 30,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == teniskiTeren1Id && x.TipRezervacijeId == dnevnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = teniskiTeren1Id,
                    TipRezervacijeId = dnevnaId,
                    Cijena = 200,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            if (!context.Cjenovniks.Any(x => x.TerenId == teniskiTeren1Id && x.TipRezervacijeId == satnaId))
            {
                context.Cjenovniks.Add(new Cjenovnik
                {
                    TerenId = teniskiTeren1Id,
                    TipRezervacijeId = satnaId,
                    Cijena = 30,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }
            context.SaveChanges();
            var fudbalskiTeren1DnevnaId = context.Cjenovniks.FirstOrDefault(x => x.TerenId == fudbalskiTeren1Id && x.TipRezervacijeId == dnevnaId).Id;
            var fudbalskiTeren1SatnaId = context.Cjenovniks.FirstOrDefault(x => x.TerenId == fudbalskiTeren1Id && x.TipRezervacijeId == satnaId).Id;
            var fudbalskiTeren2DnevnaId = context.Cjenovniks.FirstOrDefault(x => x.TerenId == fudbalskiTeren2Id && x.TipRezervacijeId == dnevnaId).Id;
            var fudbalskiTeren2SatnaId = context.Cjenovniks.FirstOrDefault(x => x.TerenId == fudbalskiTeren2Id && x.TipRezervacijeId == satnaId).Id;

            #endregion CJENOVNIKS

            #region TERMIN

            if (!context.Termins.Any(x => x.CjenovnikId == fudbalskiTeren1SatnaId && x.TerenId == fudbalskiTeren1Id
                && x.Datum == new DateTime(2023,1,1) && x.Pocetak == new DateTime(2023,1,1, 10,0,0) && x.Kraj == new DateTime(2023,1,1,12,0,0)))
            {
                context.Termins.Add(new Termin
                {
                    CjenovnikId = fudbalskiTeren1SatnaId,
                    TerenId = fudbalskiTeren1Id,
                    Datum = new DateTime(2023, 1,1),
                    Pocetak = new DateTime(2023, 1,1,10,0,0),
                    Kraj = new DateTime(2023, 1,1,12,0,0),
                    UkupnaCijena = 60,
                    IsPotvrdjen = true,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                });
            }
            if (!context.Termins.Any(x => x.CjenovnikId == fudbalskiTeren1SatnaId && x.TerenId == fudbalskiTeren1Id
               && x.Datum == new DateTime(2023, 1, 1) && x.Pocetak == new DateTime(2023, 1, 1, 12, 0, 0) && x.Kraj == new DateTime(2023, 1, 1, 15, 0, 0)))
            {
                context.Termins.Add(new Termin
                {
                    CjenovnikId = fudbalskiTeren1SatnaId,
                    TerenId = fudbalskiTeren1Id,
                    Datum = new DateTime(2023, 1, 1),
                    Pocetak = new DateTime(2023, 1, 1, 12, 0, 0),
                    Kraj = new DateTime(2023, 1, 1, 15, 0, 0),
                    UkupnaCijena = 60,
                    IsPotvrdjen = true,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                });
            }
            if (!context.Termins.Any(x => x.CjenovnikId == fudbalskiTeren2SatnaId && x.TerenId == fudbalskiTeren2Id
               && x.Datum == new DateTime(2022, 10, 1) && x.Pocetak == new DateTime(2022, 10, 1, 12, 0, 0) && x.Kraj == new DateTime(2022, 10, 1, 15, 0, 0)))
            {
                context.Termins.Add(new Termin
                {
                    CjenovnikId = fudbalskiTeren2SatnaId,
                    TerenId = fudbalskiTeren2Id,
                    Datum = new DateTime(2022, 10, 1),
                    Pocetak = new DateTime(2022, 10, 1, 12, 0, 0),
                    Kraj = new DateTime(2022, 10, 1, 15, 0, 0),
                    UkupnaCijena = 60,
                    IsPotvrdjen = true,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                });
            }
            context.SaveChanges();
            
            #endregion TERMIN

            #region TURNIR

            if (!context.Turnirs.Any(x => x.Naziv == "FA KUP"))
            {
                context.Turnirs.Add(new Turnir
                {
                    Naziv = "FA KUP",
                    CjenovnikId = fudbalskiTeren2DnevnaId,
                    TerenId = fudbalskiTeren2Id,
                    DatumPocetka = new DateTime(2023, 1, 2),
                    DatumKraja = new DateTime(2023, 1, 3),
                    VrijemePocetka = 10,
                    VrijemeKraja = 15,
                    IsGenerisan = true,
                    IsPotvrdjen = true,
                    UkupnaCijena = 400,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                });
            }
            if (!context.Turnirs.Any(x => x.Naziv == "LIGA KUP"))
            {
                context.Turnirs.Add(new Turnir
                {
                    Naziv = "LIGA KUP",
                    CjenovnikId = fudbalskiTeren2DnevnaId,
                    TerenId = fudbalskiTeren2Id,
                    DatumPocetka = new DateTime(2023, 1, 4),
                    DatumKraja = new DateTime(2023, 1, 5),
                    VrijemePocetka = 10,
                    VrijemeKraja = 15,
                    IsGenerisan = false,
                    IsPotvrdjen = true,
                    UkupnaCijena = 400,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                });
            }
            context.SaveChanges();

            var faKupTurnirId = context.Turnirs.FirstOrDefault(x => x.Naziv == "FA KUP").Id;
            var ligaKupTurnirId = context.Turnirs.FirstOrDefault(x => x.Naziv == "LIGA KUP").Id;

            #endregion TURNIR

            #region TIM

            if (!context.Tims.Any(x => x.Naziv == "Arsenal" && x.Turnir.Naziv == "FA KUP"))
            {
                context.Tims.Add(new Tim
                {
                    Naziv = "Arsenal",
                    TurnirId = faKupTurnirId,
                    CreatedAt = DateTime.Now,
                    BrojBodova = 3,
                    BrojDatihGolova = 1,
                    BrojPrimljenihGolova = 0,
                    BrojPobjeda = 1,
                    BrojNerijesenih = 0,
                    BrojPoraza = 0,
                    IsDeleted = false,
                });
            }
            if (!context.Tims.Any(x => x.Naziv == "Liverpul" && x.Turnir.Naziv == "FA KUP"))
            {
                context.Tims.Add(new Tim
                {
                    Naziv = "Liverpul",
                    TurnirId = faKupTurnirId,
                    CreatedAt = DateTime.Now,
                    BrojBodova = 0,
                    BrojDatihGolova = 0,
                    BrojPrimljenihGolova = 1,
                    BrojPobjeda = 0,
                    BrojNerijesenih = 0,
                    BrojPoraza = 1,
                    IsDeleted = false,
                });
            }
            context.SaveChanges();
            var arsenalId = context.Tims.First(x => x.Naziv == "Arsenal").Id;
            var liverpulId = context.Tims.First(x => x.Naziv == "Liverpul").Id;

            #endregion TIM

            #region UTAKMICA

            if (!context.Utakmicas.Any(x => x.DomacinId == arsenalId && x.GostId == liverpulId))
            {
                context.Utakmicas.Add(new Utakmica
                {
                    DomacinId = arsenalId,
                    GostId = liverpulId,
                    BrojGolovaDomacina = 1,
                    BrojGolovaGosta = 0,
                    TurnirId = faKupTurnirId,
                    IsZavrsena = true,
                    VrijemeUtakmice = new DateTime(2023,1,2, 10,0,0)
                });
            }
            
            context.SaveChanges();
            #endregion UTAKMICA
        }
    }
}
