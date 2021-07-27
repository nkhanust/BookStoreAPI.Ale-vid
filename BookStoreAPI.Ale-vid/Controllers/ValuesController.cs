using BookStoreAPI.Ale_vid;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var test = new string[] { "Values1", "values2", "values3", "values4" };
            return test;
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "The value is " + id;
        }

    }


}