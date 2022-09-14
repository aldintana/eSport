using System;

namespace eSport.Model
{
    public class Termin
    {
        public int Id { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
        public DateTime Datum { get; set; }
        public virtual Teren Teren { get; set; }
        public int TerenId { get; set; }
        public virtual Cjenovnik Cjenovnik { get; set; }
        public int CjenovnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int? KorisnikId { get; set; }
        public bool IsPotvrdjen { get; set; }
        public int UkupnaCijena { get; set; }
        public string TerenNaziv => Teren?.Naziv;
    }
}
