using System;
namespace eSport.Model
{
    public class TurnirSearchRequest : BaseSearchRequest
    {
        public string Naziv { get; set; }
        public int? CjenovnikId { get; set; }
        public int? TerenId { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }
        public bool? IsPotvrdjen { get; set; }
        public bool? IsGenerisan { get; set; }
        public DateTime? DoDatuma { get; set; }
        public DateTime? OdDatuma { get; set; }
    }
}
