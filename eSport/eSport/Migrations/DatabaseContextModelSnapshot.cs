﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eSport.Database;

namespace eSport.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eSport.Database.Cjenovnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cijena")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TerenId")
                        .HasColumnType("int");

                    b.Property<int>("TipRezervacijeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerenId");

                    b.HasIndex("TipRezervacijeId");

                    b.ToTable("Cjenovniks");
                });

            modelBuilder.Entity("eSport.Database.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("KorisnickoIme")
                        .IsUnique()
                        .HasFilter("[KorisnickoIme] IS NOT NULL");

                    b.ToTable("Korisniks");
                });

            modelBuilder.Entity("eSport.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisnikUlogas");
                });

            modelBuilder.Entity("eSport.Database.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("eSport.Database.Teren", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SportId");

                    b.ToTable("Terens");
                });

            modelBuilder.Entity("eSport.Database.Termin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CjenovnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPotvrdjen")
                        .HasColumnType("bit");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Kraj")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Pocetak")
                        .HasColumnType("datetime2");

                    b.Property<int>("TerenId")
                        .HasColumnType("int");

                    b.Property<int>("UkupnaCijena")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CjenovnikId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TerenId");

                    b.ToTable("Termins");
                });

            modelBuilder.Entity("eSport.Database.Tim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojBodova")
                        .HasColumnType("int");

                    b.Property<int>("BrojDatihGolova")
                        .HasColumnType("int");

                    b.Property<int>("BrojNerijesenih")
                        .HasColumnType("int");

                    b.Property<int>("BrojPobjeda")
                        .HasColumnType("int");

                    b.Property<int>("BrojPoraza")
                        .HasColumnType("int");

                    b.Property<int>("BrojPrimljenihGolova")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurnirId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurnirId");

                    b.ToTable("Tims");
                });

            modelBuilder.Entity("eSport.Database.TipRezervacije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDnevna")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipRezervacijes");
                });

            modelBuilder.Entity("eSport.Database.Turnir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CjenovnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumKraja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPotvrdjen")
                        .HasColumnType("bit");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TerenId")
                        .HasColumnType("int");

                    b.Property<int>("UkupnaCijena")
                        .HasColumnType("int");

                    b.Property<int>("VrijemeKraja")
                        .HasColumnType("int");

                    b.Property<int>("VrijemePocetka")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CjenovnikId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TerenId");

                    b.ToTable("Turnirs");
                });

            modelBuilder.Entity("eSport.Database.Uloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ulogas");
                });

            modelBuilder.Entity("eSport.Database.Cjenovnik", b =>
                {
                    b.HasOne("eSport.Database.Teren", "Teren")
                        .WithMany()
                        .HasForeignKey("TerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eSport.Database.TipRezervacije", "TipRezervacije")
                        .WithMany()
                        .HasForeignKey("TipRezervacijeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teren");

                    b.Navigation("TipRezervacije");
                });

            modelBuilder.Entity("eSport.Database.KorisnikUloga", b =>
                {
                    b.HasOne("eSport.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUlogas")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eSport.Database.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("eSport.Database.Teren", b =>
                {
                    b.HasOne("eSport.Database.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("eSport.Database.Termin", b =>
                {
                    b.HasOne("eSport.Database.Cjenovnik", "Cjenovnik")
                        .WithMany()
                        .HasForeignKey("CjenovnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eSport.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("eSport.Database.Teren", "Teren")
                        .WithMany()
                        .HasForeignKey("TerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cjenovnik");

                    b.Navigation("Korisnik");

                    b.Navigation("Teren");
                });

            modelBuilder.Entity("eSport.Database.Tim", b =>
                {
                    b.HasOne("eSport.Database.Turnir", "Turnir")
                        .WithMany()
                        .HasForeignKey("TurnirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turnir");
                });

            modelBuilder.Entity("eSport.Database.Turnir", b =>
                {
                    b.HasOne("eSport.Database.Cjenovnik", "Cjenovnik")
                        .WithMany()
                        .HasForeignKey("CjenovnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eSport.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("eSport.Database.Teren", "Teren")
                        .WithMany()
                        .HasForeignKey("TerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cjenovnik");

                    b.Navigation("Korisnik");

                    b.Navigation("Teren");
                });

            modelBuilder.Entity("eSport.Database.Korisnik", b =>
                {
                    b.Navigation("KorisnikUlogas");
                });
#pragma warning restore 612, 618
        }
    }
}
