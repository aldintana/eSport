﻿using AutoMapper;
using eSport.Database;
using eSport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class SportService : BaseCRUDService<Model.Sport, object, Database.Sport, SportInsertRequest, SportInsertRequest>, ISportService
    {
        public SportService(DatabaseContext context, IMapper mapper) : base (context, mapper)
        {
           
        }
    }
}
