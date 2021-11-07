using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportController : ControllerBase
    {
        private readonly ISportService _service;
        public SportController(ISportService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Sport> Get()
        {
            return _service.Get();
        }
    }
}
