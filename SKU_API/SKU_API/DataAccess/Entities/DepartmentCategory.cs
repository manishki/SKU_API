using System;

namespace SKU_API.DataAccess.Entities
{
    public class DepartmentCategory
    {
        public Guid CategoryId { get; set; }
        public Catrgory Catrgory { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

    }

}
