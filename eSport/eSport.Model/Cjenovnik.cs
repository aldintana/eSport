﻿namespace eSport.Model
{
    public class Cjenovnik
    {
        public int Id { get; set; }
        public int Cijena { get; set; }
        public int TerenId { get; set; }
        public virtual Teren Teren { get; set; }
        public int TipRezervacijeId { get; set; }
        public virtual TipRezervacije TipRezervacije { get; set; }
    }
}