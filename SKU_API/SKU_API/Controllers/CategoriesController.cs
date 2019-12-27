﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SKU_API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        [Route("locations/{location_id}/departments/{department_id}/categories")]
        public IActionResult Get(string location_id, string department_id)
        {
            return Ok(new { location_id, department_id });
        }
    }
}