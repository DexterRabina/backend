using Microsoft.EntityFrameworkCore;

namespace backenddotnet.Models
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PinakaFinal;User Id=postgres;Password=Generose@1;");
        }
    }
}
