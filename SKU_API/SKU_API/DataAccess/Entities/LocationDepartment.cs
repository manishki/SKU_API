using System;

namespace SKU_API.DataAccess.Entities
{
    public class LocationDepartment
    {
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid LocationId { get; set; }

        public Location Location { get; set; }

    }


}
