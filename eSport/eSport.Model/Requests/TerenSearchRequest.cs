using System;
using System.Collections.Generic;
using System.Text;

namespace eSport.Model
{
    public class TerenSearchRequest
    {
        public string Naziv { get; set; }
        public int? SportId { get; set; }

        public string[] IncludeList { get; set; }
    }
}
