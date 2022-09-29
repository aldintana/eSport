using System;

namespace eSport.Model
{
    public class TurnirInsertRequest
    {
        public string Naziv { get; set; }
        public int TerenId { get; set; }
        public int CjenovnikId { get; set; }
        public int? KorisnikId { get; set; }
        public int UkupnaCijena { get; set; }
        public bool IsPotvrdjen { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public int VrijemePocetka { get; set; }
        public int VrijemeKraja { get; set; }
    }
}
