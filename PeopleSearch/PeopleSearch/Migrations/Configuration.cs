namespace PeopleSearch.Migrations
{
    using PeopleSearch.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearch.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    /*
     *  Populating the db with data.
     *  In Package Manager run Update-Database to seed data. 
     */
    protected override void Seed(PeopleSearch.Data.ApplicationDbContext context)
        {
            context.Persons.AddOrUpdate(x => x.Id,
            new Person() { Id = 1, Name = "Mike Bell", Age = 39, Line = "7130 Robin Sound", City = "Pearland", State = "TX", Zip = 77581, Interests = "Traveling, Playing the Ukulele, Singing in a Chior, Swimming, Coding, Movies, Video Games, Thai Food", ImgPath = "/assets/mikebell.jpg" },
            new Person() { Id = 2, Name = "Laura Palmer-Bell", Age = 34, Line = "7130 Robin Sound", City = "Pearland", State = "TX", Zip = 77581, Interests = "Traveling, Politics, Singing in a Chior, Cop Dramas, Harry Potter, Star Wars, Reading, Education", ImgPath = "/assets/LauraPalmerBell.jpg" },
            new Person() { Id = 3, Name = "John Doe", Age = 55, Line = "55 Fake Steet", City = "Houston", State = "TX", Zip = 77035, Interests = "Reading, Walking, Crocheting, Arcaeology", ImgPath = "/assets/JohnDoe.jpg" },
            new Person() { Id = 4, Name = "Jane Doe", Age = 28, Line = "123 No Name", City = "Houston", State = "TX", Zip = 77077, Interests = "iPhone, Texting, Reading, Trying Something New", ImgPath = "/assets/JaneDoe.jpg" },
            new Person() { Id = 5, Name = "Anthony Lomax", Age = 7, Line = "77 Test Way", City = "Houston", State = "TX", Zip = 77077, Interests = "Playing Music, Speding Time with Friends, Running and Jumping", ImgPath = "/assets/AnthonyLomax.jpg" },
            new Person() { Id = 6, Name = "Pete Toto", Age = 1, Line = "111 New Street Way", City = "Dallas", State = "TX", Zip = 75043, Interests = "Watching Lights, Sleeping, Eating, More Sleeping, Drooling", ImgPath = "/assets/PeteToto.jpg" }
            );
        }
    }
}
