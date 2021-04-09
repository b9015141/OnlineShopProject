using Microsoft.EntityFrameworkCore;


namespace OnlineShopProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

       

        public DbSet<OurWork> OurWork { get; set; }

        public DbSet<UserRegistration> Registers { get; set; }
    }
}

