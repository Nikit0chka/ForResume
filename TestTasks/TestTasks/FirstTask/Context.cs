using DataBaseModel;
using Microsoft.EntityFrameworkCore;

namespace DatBaseContext;

internal class Context : DbContext
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Mode> Modes { get; set; }
    public DbSet<Command> Commands { get; set; }

    public Context()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Tickets;Trusted_Connection=True;");
    }
}