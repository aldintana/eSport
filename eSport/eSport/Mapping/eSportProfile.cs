using AutoMapper;
using eSport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
