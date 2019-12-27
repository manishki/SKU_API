using Microsoft.AspNetCore.Mvc;
using SKU_API.DataAccess;
using SKU_API.DataAccess.Entities;
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
        public LocationsController(SkuDbContext skuDbContext)
        {
            _skuDbContext = skuDbContext;
        }

        private readonly SkuDbContext _skuDbContext;

        [HttpGet]
        public IActionResult Get()
        {
            var obj = new { Name = "Manish", Age = 28, Education= "MCA" };

            //using (var context = new SkuDbContext())
            //{
            var id = Guid.NewGuid();
                var cat = new Catrgory()
                {
                    CatrgoryId = id,
                    Name = "abc"
                };
            _skuDbContext.Catrgories.Add(cat);
            _skuDbContext.SaveChanges();
            //}


            //using (var context = new SkuDbContext())
            //{
                var catrogry = _skuDbContext.Catrgories.Where(x => x.CatrgoryId == id);
                return Ok(catrogry);
            //}

            //return Ok();

          
        }
    }
}
