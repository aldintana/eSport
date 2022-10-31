using System;
namespace eSport.Model
{
    public class TerminSearchRequest : BaseSearchRequest
    {
        public int? CjenovnikId { get; set; }
        public int? TerenId { get; set; }
        public int? SportId { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? OdDatuma { get; set; }
        public DateTime? DoDatuma { get; set; }
        public DateTime? Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
        public bool? IsPotvrdjen { get; set; }
    }
}
