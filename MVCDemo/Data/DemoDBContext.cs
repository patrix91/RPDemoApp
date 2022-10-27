using Microsoft.EntityFrameworkCore;

namespace MVCDemo.Data
{
    public class DemoDBContext: DbContext
    {
        public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options)
        {
            
        }
    }
}