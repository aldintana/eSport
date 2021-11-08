using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Model.Requests;
using eSport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    public class SportController : BaseCRUDController<Model.Sport, object, SportInsertRequest, SportInsertRequest>
    {
        public SportController(ISportService service) : base(service)
        {
            
        }

    }
}
