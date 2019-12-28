using Microsoft.AspNetCore.Mvc;
using SKU_API.DataAccess;
using SKU_API.DataAccess.Entities;
using SKU_API.DataAccess.Interfaces;
using SKU_API.DataAccess.Repositories;
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
        public LocationsController(ILocationRepositoty location)
        {
            _location = location;
        }

        private readonly ILocationRepositoty _location;

        [HttpGet]
        public IActionResult Get()
        {
           
            var id = Guid.NewGuid();
            var loc = new Location()
            {
                LocationId = id,
                Name = "Hyderabad"
            };
            
            _location.Post(loc);


            
            var location = _location.Get(id);
                return Ok(location);

          
        }
    }
}
