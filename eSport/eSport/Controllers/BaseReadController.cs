﻿using eSport.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eSport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseReadController<T, TSearch> : ControllerBase where T:class where TSearch:class
    {
        protected readonly IReadService<T, TSearch> _service;
        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
