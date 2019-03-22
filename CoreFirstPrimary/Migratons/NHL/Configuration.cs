using CoreFirstPrimary.Data;

namespace CoreFirstPrimary.Migratons.NHL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoreFirstPrimary.Data.NHLContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migratons\NHL";
        }

        protected override void Seed(CoreFirstPrimary.Data.NHLContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(
               x=>x.TeamName, DummyData.GeTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(
                x => new { x.FirstName, x.LastName }, DummyData.GetPlayers(context).ToArray());
        }
    }
}
