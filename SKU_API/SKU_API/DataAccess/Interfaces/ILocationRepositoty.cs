using SKU_API.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKU_API.DataAccess.Interfaces
{
    public interface ILocationRepositoty
    {
        Location Delete(Location location);
        void Dispose();
        IList<Location> Get();
        Location Get(Guid id);
        int Post(Location location);
        int Put(Location location);
    }
}
