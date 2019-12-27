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
    public class SubCategoriesController : ControllerBase
    {
        [HttpGet]
        [Route("locations/{location_id}/departments/{department_id}/categories/{category_id}/subcategories")]
        public IActionResult Get(string location_id, string department_id, string category_id)
        {
            return Ok(new { location_id, department_id, category_id });
        }
        
        [HttpGet]
        [Route("locations/{location_id}/departments/{department_id}/categories/{category_id}/subcategories/{subcategory_id}")]
        public IActionResult Get(string location_id, string department_id, string category_id, string subcategory_id)
        {
            return Ok(new { location_id, department_id, category_id, subcategory_id });
        }
    }
}