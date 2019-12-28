using SKU_API.DataAccess.Entities;
using SKU_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKU_API.DataAccess.Repositories
{
    public class LocationRepositoty : ILocationRepositoty
    {
        private readonly SkuDbContext _skuDbContext;

        public LocationRepositoty(SkuDbContext skuDbContext)
        {
            this._skuDbContext = skuDbContext;
        }
        public Location Delete(Location location)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _skuDbContext.Dispose();
        }

        public IList<Location> Get()
        {
            return _skuDbContext.Locations.ToList();
        }

        public Location Get(Guid id)
        {
            return _skuDbContext.Locations.Find(id);
        }

        public int Post(Location location)
        {
            _skuDbContext.Locations.Add(location);
            var added = _skuDbContext.SaveChanges();
            return added;
        }

        public int Put(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
