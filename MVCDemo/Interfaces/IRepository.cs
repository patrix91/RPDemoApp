using MVCDemo.Models;

namespace MVCDemo.Interfaces
{
    public interface IRepository
    {
        public IQueryable<Car> Cars { get; }

        void Add<EntityType>(EntityType entityType);

        void SaveChanges();
    }
}
