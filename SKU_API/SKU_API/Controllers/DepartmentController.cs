using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SKU_API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        [Route("locations/{location_id}/departments")]
        public IActionResult Get(string location_id)
        {
            return Ok(location_id);
        }
    }
}