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
    public class TerenController : BaseCRUDController<Model.Teren, TerenSearchRequest, TerenInsertRequest, TerenInsertRequest>
    {
        public TerenController(ITerenService terenService) : base(terenService)
        {
        }
    }
}
