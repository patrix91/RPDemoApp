using System.Collections.Generic;
using MVCDemo.Interfaces;
using MVCDemo.Models;
using System.Linq;

namespace InMemoryDatabase.Tests.Mocks;
internal class MockRepository : IRepository
{
    private readonly List<Car> cars = new List<Car>();
    private readonly IRepository repository;

    public IQueryable<Car> Cars => cars.AsQueryable();

    public MockRepository(IRepository repository)
    {
        this.repository = repository;
    }

    public void Add<EntityType>(EntityType entity)
    {
        switch (entity)
        {
            case FuelCar fuelCar:
                cars.Add(fuelCar);
                break;
            case ElectricCar electricCar:
                cars.Add(electricCar);
                break;
        }
    }

    public void SaveChanges() { }
}
