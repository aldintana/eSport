namespace eSport.Database
{
    public class TipRezervacije : TEntity<Uloga>
    {
        public string Naziv { get; set; }
        public bool IsDnevna { get; set; }
    }
}
