using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKU_API.DataAccess.Entities;

namespace SKU_API.DataAccess

{
    public class SkuDbContext : DbContext
    {        

        public DbSet<Location> Locations { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Catrgory> Catrgories { get; set; }

        public DbSet<SubCatrgory> SubCatrgories { get; set; }

        public SkuDbContext(DbContextOptions<SkuDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationDepartment>().HasKey(sc => new { sc.LocationId, sc.DepartmentId });
            modelBuilder.Entity<DepartmentCategory>().HasKey(sc => new { sc.DepartmentId, sc.CategoryId });
            modelBuilder.Entity<CatrgorySubCatrgory >().HasKey(sc => new { sc.CatrgoryId, sc.SubCatrgoryId });
            
        }
        //public SkuDbContext(DbContextOptions<SkuDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=localhost;Database=SkuDb;Username=postgress;Password=Welcome@1");




    }

}
