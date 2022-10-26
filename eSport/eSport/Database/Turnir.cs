using System;

namespace eSport.Database
{
    public class Turnir : TEntity<Turnir>
    {
        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public int VrijemePocetka { get; set; }
        public int VrijemeKraja { get; set; }
        public virtual Teren Teren { get; set; }
        public int TerenId { get; set; }
        public virtual Cjenovnik Cjenovnik { get; set; }
        public int CjenovnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int? KorisnikId { get; set; }
        public bool IsPotvrdjen { get; set; }
        public int UkupnaCijena { get; set; }
        public bool IsGenerisan { get; set; }

    }
}
