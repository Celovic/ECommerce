using ECommerce.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Entities.Context
{
    public class ECommerceDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-154APPP; Database = ECommerce; Integrated Security = true; Trusted_Connection = True;MultipleActiveResultSets=True");
        }
        public DbSet<Product> TBLProduct { get; set; }
        public DbSet<Category> TBLCategory{ get; set; }
    }
}
