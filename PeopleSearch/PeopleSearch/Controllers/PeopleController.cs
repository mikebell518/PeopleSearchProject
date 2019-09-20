using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using PeopleSearch.Data;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers
{
  /*
   * Controller API for PeopleSearch search method.
   * Returns a JSON object Persons
   * urlpath: /api/people
   * Paramaters: searchString - Optional
   * /api/people?searchString="name"
  */
  public class PeopleController : ApiController
  {
    private ApplicationDbContext db = new ApplicationDbContext();

    public IQueryable<Person> GetPersons(string searchString = "")
    {
      Random random = new Random();
      // 
      System.Threading.Thread.Sleep(random.Next(1, 3000));
      switch (searchString)
      {
        case "":
          return db.Persons;
        default:
          return db.Persons.Where(p => p.Name.Contains(searchString));
      }

    }
  }
}
