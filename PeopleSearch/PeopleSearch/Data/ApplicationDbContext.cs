using System.Data.Entity;
using PeopleSearch.Models;

namespace PeopleSearch.Data
{
    public class ApplicationDbContext : DbContext
    {
    public virtual DbSet<Person> Persons { get; set; }
    public ApplicationDbContext() :
    base("DbConnectionString")
    {
    }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }

        
    }
}
