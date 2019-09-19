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

        protected override void Seed(PeopleSearch.Data.ApplicationDbContext context)
        {
            context.Persons.AddOrUpdate(x => x.Id,
            new Person() { Id = 1, Name = "Mike Bell", Age = 39, Line = "7130 Robin Sound", City = "Pearland", State = "TX", Zip = 77581, Interests = "Ukulele,Swimming,Coding", ImgPath = "https://scontent.fhou1-2.fna.fbcdn.net/v/t1.0-9/10445526_681933938528755_8641991946683810888_n.jpg?_nc_cat=106&_nc_oc=AQmOnlylqqNnEgkn-LeOmd_VnUbP-mz36EV49jtRjxr6lne_KSv3oQh0lNW8IKsZa3Q&_nc_ht=scontent.fhou1-2.fna&oh=1b331df54346a7354a85c946898eda77&oe=5E0AA36D" },
            new Person() { Id = 2, Name = "Laura Palmer Bell", Age = 32, Line = "7130 Robin Sound", City = "Pearland", State = "TX", Zip = 77581, Interests = "Ukulele,Swimming,Coding", ImgPath = "https://scontent.fhou1-2.fna.fbcdn.net/v/t1.0-9/10445526_681933938528755_8641991946683810888_n.jpg?_nc_cat=106&_nc_oc=AQmOnlylqqNnEgkn-LeOmd_VnUbP-mz36EV49jtRjxr6lne_KSv3oQh0lNW8IKsZa3Q&_nc_ht=scontent.fhou1-2.fna&oh=1b331df54346a7354a85c946898eda77&oe=5E0AA36D" }
            );
        }
    }
}
