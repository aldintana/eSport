﻿using AutoMapper;
using eSport.Model;

namespace eSport.Mapping
{
    public class eSportProfile : Profile
    {
        public eSportProfile()
        {
            CreateMap<Database.Sport, Model.Sport>().ReverseMap();
            CreateMap<SportInsertRequest, Database.Sport>();
            CreateMap<Model.Sport, SportInsertRequest>();
            CreateMap<Database.Teren, Model.Teren>().ReverseMap();
            CreateMap<TerenInsertRequest, Database.Teren>();
            CreateMap<Model.Teren, TerenInsertRequest>();
            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();
            CreateMap<Model.Korisnik, KorisnikInsertRequest>();
            CreateMap<Database.Uloga, Model.Uloga>().ReverseMap();
            CreateMap<Database.KorisnikUloga, Model.KorisnikUloga>().ReverseMap();
            CreateMap<Database.TipRezervacije, Model.TipRezervacije>().ReverseMap();
            CreateMap<Database.Cjenovnik, Model.Cjenovnik>().ReverseMap();
            CreateMap<Model.Cjenovnik, CjenovnikInsertRequest>();
            CreateMap<CjenovnikInsertRequest, Database.Cjenovnik>();
            CreateMap<Database.Termin, Model.Termin>().ReverseMap();
            CreateMap<Model.Termin, TerminInsertRequest>();
            CreateMap<TerminInsertRequest, Database.Termin>();
            CreateMap<Database.Turnir, Model.Turnir>().ReverseMap();
            CreateMap<Model.Turnir, TurnirInsertRequest>();
            CreateMap<TurnirInsertRequest, Database.Turnir>().ReverseMap();
            CreateMap<Database.Tim, Model.Tim>().ReverseMap();
            CreateMap<Model.Tim, TimInsertRequest>();
            CreateMap<TimInsertRequest, Database.Tim>();
            CreateMap<Database.Utakmica, Model.Utakmica>().ReverseMap();
            CreateMap<Model.Utakmica, UtakmicaInsertRequest>();
            CreateMap<UtakmicaInsertRequest, Database.Utakmica>();
        }
    }
}
