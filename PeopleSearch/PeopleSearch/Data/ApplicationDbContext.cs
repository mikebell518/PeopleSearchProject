using System.Data.Entity;
using PeopleSearch.Models;

namespace PeopleSearch.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("DbConnectionString")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Person> Persons { get; set; }
    }
}