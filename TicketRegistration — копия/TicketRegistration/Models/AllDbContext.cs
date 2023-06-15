using Microsoft.EntityFrameworkCore;

namespace TicketRegistration;

public class AllDbContext : DbContext
{
    public AllDbContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<AvailableCountry> AvailableCountries { get; set; }
    public DbSet<AvailableCity> AvailableCities { get; set; }
    public DbSet<Plane> Planes { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Tickets;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AvailableCity>().HasOne(c => c.Country).WithMany().OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Flight>().HasOne(c => c.ArrivalCity).WithMany().OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Flight>().HasOne(c => c.DepartureCity).WithMany().OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Ticket>().HasOne(c => c.ArrivalCity).WithMany().OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Ticket>().HasOne(c => c.Plane).WithMany().OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Ticket>().HasOne(c => c.Flight).WithMany().OnDelete(DeleteBehavior.NoAction);
    }
}