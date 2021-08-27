using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_identity_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelAgencyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var user = HttpContext.User;
            return Ok("ok");
        }
    }
}
