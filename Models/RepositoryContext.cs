using Microsoft.EntityFrameworkCore;
using Otel_MVC.Models;

namespace Otel_MVC.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Hotel>().HasData(
        //         new Hotel { HotelId=1}
        //     );
        // }
    }
}