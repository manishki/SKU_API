using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKU_API.DataAccess.Interfaces
{
    public interface IEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime LastModified { get; set; }

        public DateTime Created { get; set; }

    }
}
