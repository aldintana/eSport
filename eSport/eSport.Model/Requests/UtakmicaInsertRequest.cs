using System;

namespace eSport.Model
{
    public class UtakmicaInsertRequest
    {
        public int DomacinId { get; set; }
        public int GostId { get; set; }
        public int TurnirId { get; set; }
        public int BrojGolovaDomacina { get; set; }
        public int BrojGolovaGosta { get; set; }
        public DateTime VrijemeUtakmice { get; set; }
    }
}
