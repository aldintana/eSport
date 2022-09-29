namespace eSport.Database
{
    public class Tim : TEntity<Tim>
    {
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
