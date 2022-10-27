using System;

namespace eSport.Model
{
    public class UtakmicaSearchRequest : BaseSearchRequest
    {
        public int? DomacinId { get; set; }
        public int? GostId { get; set; }
        public int? TurnirId { get; set; }
        public bool? IsZavrsena { get; set; }
        public DateTime? VrijemeUtakmice { get; set; }
    }
}
