using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eSport.Model
{
    public class KorisnikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^\\d{3}-\\d{3}-(\\d{4}|\\d{3})$")]
        public string BrojTelefona { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        public string Lozinka { get; set; }
        [Compare("Lozinka")]
        public string LozinkaProvjera { get; set; }
        public bool UpdateUloga { get; set; }
        public List<int> Ulogas { get; set; } = new List<int>();
        public int Bodovi { get; set; }
    }
}
