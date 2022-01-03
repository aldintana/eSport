﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eSport.Model
{
    public class Teren
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SportId { get; set; }
        public virtual Sport Sport { get; set; }
    }
}
