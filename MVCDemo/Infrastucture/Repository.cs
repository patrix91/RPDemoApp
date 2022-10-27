using MVCDemo.Interfaces;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Infrastucture
{
    public class Repository: IRepository
    {
        public IQueryable<Car> Cars => demoDBContext.Cars;
        private readonly DemoDBContext demoDBContext;

        public Repository(DemoDBContext demoDBContext)
        {
            this.demoDBContext = demoDBContext;
        }

        public void Add<EntityType>(EntityType entityType) => demoDBContext.Add(entity);

        public void SaveChanges() => demoDBContext.SaveChanges();
    }
}
