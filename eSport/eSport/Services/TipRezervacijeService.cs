using AutoMapper;
using eSport.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public class TipRezervacijeService : BaseReadService<Model.TipRezervacije, Database.TipRezervacije, object>, ITipRezervacijeService
    {
        public TipRezervacijeService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
    }
}
