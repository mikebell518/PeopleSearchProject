using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Controllers;
using PeopleSearch.Data;
using PeopleSearch.Models;

namespace PeopleSearch.Tests
{
    [TestClass]
    public class TestPeopleSearchController
    {
        [TestMethod]
        public void GetAllPersons_ShouldReturnAllPerson()
        {
            var testPersons = GetTestPersons();
            var controller = new PeopleController();

            var result = controller.GetPersons("") as IQueryable<Person>;
            var test = result.Select(s => new { s.Id }).ToList();
            var test2 = result;
            Assert.AreEqual(testPersons, result);
        }

            private IQueryable<Person> GetTestPersons()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Persons;
    }
    }
}

