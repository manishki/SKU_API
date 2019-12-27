using System;

namespace SKU_API.DataAccess.Entities
{
    public class CatrgorySubCatrgory
    {
        public Guid CatrgoryId { get; set; }
        public Catrgory Catrgory { get; set; }

        public Guid SubCatrgoryId { get; set; }
        public SubCatrgory SubCatrgory { get; set; }
    }


}
