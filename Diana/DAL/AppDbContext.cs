using Diana.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;

namespace Diana.DAL
{
    public class AppDbContext :IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
    }
}
