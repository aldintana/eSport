namespace eSport.Database
{
    public class Cjenovnik : TEntity<Cjenovnik>
    {
        public int Cijena { get; set; }
        public virtual TipRezervacije TipRezervacije { get; set; }
        public int TipRezervacijeId { get; set; }
        public virtual Teren Teren { get; set; }
        public int TerenId { get; set; }
    }
}
