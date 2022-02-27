using System.ComponentModel.DataAnnotations;

namespace eSport.Model
{
    public class TerenInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public int SportId { get; set; }
    }
}
