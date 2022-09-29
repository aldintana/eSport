using System;

namespace eSport.Model
{
    public class Tim
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual Turnir Turnir { get; set; }
        public int TurnirId { get; set; }
        public int BrojBodova { get; set; }
        public int BrojPobjeda { get; set; }
        public int BrojNerijesenih { get; set; }
        public int BrojPoraza { get; set; }
        public int BrojDatihGolova { get; set; }
        public int BrojPrimljenihGolova { get; set; }
    }
}
