﻿using SKU_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace SKU_API.DataAccess.Entities
{
    public class SubCatrgory : IEntity

    {
        public Guid SubCatrgoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime Created { get; set; }

        public ICollection<CatrgorySubCatrgory> CatrgorySubCatrgories { get; set; }

    }



}
