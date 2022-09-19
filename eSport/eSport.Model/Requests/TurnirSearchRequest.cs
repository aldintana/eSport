using System;
namespace eSport.Model
{
    public class TurnirSearchRequest : BaseSearchRequest
    {
        public int? CjenovnikId { get; set; }
        public int? TerenId { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }
        public bool? IsPotvrdjen { get; set; }
    }
}
