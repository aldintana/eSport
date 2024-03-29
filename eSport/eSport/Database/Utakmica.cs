﻿using System;

namespace eSport.Database
{
    public class Utakmica : TEntity<Utakmica>
    {
        public virtual Tim Domacin { get; set; }
        public int DomacinId { get; set; }
        public virtual Tim Gost { get; set; }
        public int GostId { get; set; }
        public virtual Turnir Turnir { get; set; }
        public int TurnirId { get; set; }
        public int BrojGolovaDomacina { get; set; }
        public int BrojGolovaGosta { get; set; }
        public DateTime VrijemeUtakmice { get; set; }
        public bool IsZavrsena { get; set; }
    }
}
