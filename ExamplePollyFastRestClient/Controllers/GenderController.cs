using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePollyFastRestClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        public GenderController()
        {

        }

        [HttpGet("predict/{name}")]
        public IActionResult Predict(string name)
        {

            return Ok(name);
        }
    }
}
