using MVCDemo.Models;

namespace MVCDemo.Interfaces
{
    interface Interface
    {
        public IQueryable<Car> Cars { get; }
    }
}
