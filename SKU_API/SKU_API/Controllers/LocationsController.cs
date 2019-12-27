using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKU_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LocationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var obj = new { Name = "Manish", Age = 28, Education= "MCA" };
            
            return Ok(obj);
        }
    }
}
