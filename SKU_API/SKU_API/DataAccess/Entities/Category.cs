using SKU_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKU_API.DataAccess.Entities
{
    public class Catrgory : IEntity

    {
        public Guid CatrgoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime Created { get; set; }

        public ICollection<CatrgorySubCatrgory> CatrgorySubCatrgories { get; set; }

        public ICollection<DepartmentCategory> DepartmentCategories { get; set; }


    }


}
