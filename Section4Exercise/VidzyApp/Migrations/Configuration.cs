namespace VidzyApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VidzyApp.Core.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<VidzyApp.Persistence.VidzyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VidzyApp.Persistence.VidzyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Genres.AddOrUpdate(g => g.Name, new Genre[] {
                new Genre {Id=1, Name = "Pop" },
                new Genre {Id=2, Name = "Blues" },
                new Genre {Id=3, Name = "Rock" }
            });
        }
    }
}
