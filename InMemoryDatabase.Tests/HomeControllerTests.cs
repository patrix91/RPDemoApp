using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using MVCDemo.Infrastucture;
using MVCDemo.Controllers;
using MVCDemo.Interfaces;
using MVCDemo.Data;
using System.Linq;
using MVCDemo;

namespace InMemoryDatabase.Tests;
    
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController controller;
        private IRepository repository;

        private IRepository GetInMemoryRepository()
        {
            var options = new DbContextOptionsBuilder<DemoDBContext>()
                .UseInMemoryDatabase(databaseName: "MockDB")
                .Options;

            var context = new DemoDBContext(options);

            var repository = new Repository(context);

            return repository;
        }

        [TestInitialize]
        public void Setup()
        {
            repository = GetInMemoryRepository(); //new Mocks.MockRepository();
            controller = new HomeController(this.repository);
        }

        [TestMethod]
        public void Create()
        {
            controller.Create();

            Assert.AreEqual(1, repository.Cars.CountAsync());
            Assert.AreEqual("tesla", repository.Cars.First().Brand);
            Assert.AreEqual("p90", repository.Cars.First().Type);
            Assert.AreEqual(Energy.Electric, repository.Cars.First().EnergyType);
        }

    }
