using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MVCDemo.Data
{
    public class DemoDBContext: DbContext
    {
        public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}