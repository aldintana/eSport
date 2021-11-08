using AutoMapper;
using eSport.Model.Requests;
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
            CreateMap<Database.Sport, Model.Sport>();
            CreateMap<SportInsertRequest, Database.Sport>();
            CreateMap<Model.Sport, SportInsertRequest>();
        }
    }
}
