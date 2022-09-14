using System;

namespace eSport.Model
{
    public class TerminInsertRequest
    {
        public int TerenId { get; set; }
        public int CjenovnikId { get; set; }
        public int? KorisnikId { get; set; }
        public int UkupnaCijena { get; set; }
        public bool IsPotvrdjen { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
    }
}
