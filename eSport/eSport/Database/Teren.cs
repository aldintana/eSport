﻿namespace eSport.Database
{
    public class Teren : TEntity<Teren>
    {
        public string Naziv { get; set; }
        public virtual Sport Sport { get; set; }
        public int SportId { get; set; }
    }
}
