namespace eSport.Model
{
    public class TerenSearchRequest : BaseSearchRequest
    {
        public int? SportId { get; set; }
        public int? KorisnikId { get; set; }
    }
}
