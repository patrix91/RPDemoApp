using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MVCDemo.Data;
public class DemoDBContext : DbContext
{
    public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Car>().HasData(new ElectricCar() as Car );
    // }
}