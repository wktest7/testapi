using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Guid.NewGuid().ToString());
        }

        [HttpGet("number")]
        public IActionResult GetNumber()
        {
            var rand = new Random();
            return Ok(rand.Next(100));
        }
    }
}
