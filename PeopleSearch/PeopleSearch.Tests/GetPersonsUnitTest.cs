/*
    Unit Testing class to verify the PeopleController.
    There is a bug in this code where it is failing when it should not. 
    The mock data is not getting loaded into the virtual controller. 
    This still need to be researched. 
*/

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Models;
using System.Data.Entity;
using Moq;
using PeopleSearch.Data;
using PeopleSearch.Controllers;

namespace PeopleSearch.Tests
{
    [TestClass]
    public class TestPeopleSearchController
    {
        [TestMethod]
        public void GetAllPersons_ShouldReturnAllPersons()
        {
            var data = new List<Person>
            {
            new Person() { Id = 1, Name = "Test1", Age = 30, Line = "555 Test", City = "Pearland", State = "TX", Zip = 77581, Interests = "Testing", ImgPath = "/fakeImage.png" },
            new Person() { Id = 2, Name = "Test2", Age = 32, Line = "10 Testing", City = "Pearland", State = "TX", Zip = 77581, Interests = "Testing", ImgPath = "/fakeImage.png" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Person>>();
            mockSet.Setup(x => x.Add(It.IsAny<Person>())).Returns<Person>(p => p);
            mockSet.As<IQueryable<Person>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Person>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Person>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Person>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            
            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Persons).Returns(mockSet.Object);

            var service = new PeopleController();
            var results = service.GetPersons();
            Assert.AreEqual(2, results.Count());
        }

    }
}

