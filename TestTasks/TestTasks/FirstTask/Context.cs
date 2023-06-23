using DataBaseModel;
using Microsoft.EntityFrameworkCore;

namespace Context;

internal class Context : DbContext
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Mode> Modes { get; set; }
 
    public Context()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Tickets;Trusted_Connection=True;");
    }
}