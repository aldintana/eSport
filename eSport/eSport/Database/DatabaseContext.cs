﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Database
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Teren> Terens { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual DbSet<TipRezervacije> TipRezervacijes { get; set; }
        public virtual DbSet<Cjenovnik> Cjenovniks { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<Turnir> Turnirs { get; set; }
        public virtual DbSet<Tim> Tims { get; set; }
        public virtual DbSet<Utakmica> Utakmicas { get; set; }
    }
}
