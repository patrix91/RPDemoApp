using MVCDemo.Interfaces;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Infrastucture
{
    public class Repository: Interface
    {
        public IQueryable<Car> Cars => demoDBContext.Cars;
        private readonly DemoDBContext demoDBContext;

        public Repository(DemoDBContext demoDBContext)
        {
            this.demoDBContext = demoDBContext;
        }

    }
}
