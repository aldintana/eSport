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
        [EmailAddress()]
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        public string Lozinka { get; set; }
        [Compare("Lozinka")]
        public string LozinkaProvjera { get; set; }
        public List<int> Ulogas { get; set; } = new List<int>();
    }
}
