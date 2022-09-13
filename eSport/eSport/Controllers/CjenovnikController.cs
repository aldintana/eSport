using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    public class CjenovnikController : BaseCRUDController<Model.Cjenovnik, CjenovnikSearchRequest, CjenovnikInsertRequest, CjenovnikInsertRequest>
    {
        public CjenovnikController(ICjenovnikService cjenovnikService) : base(cjenovnikService)
        {
        }
    }
}
