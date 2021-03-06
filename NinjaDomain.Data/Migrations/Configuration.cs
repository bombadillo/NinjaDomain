namespace NinjaDomain.Data.Migrations
{
    using Classes;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaDomain.Data.Contexts.NinjaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaDomain.Data.Contexts.NinjaContext context)
        {
            context.Clans.AddOrUpdate(
                c => c.Id,
                new Clan { Id = 1, Name = "City Chicken" }
            );

            context.Ninjas.AddOrUpdate(
                n => n.Id,
                new Ninja { Id = 1, DateOfBirth = DateTime.Now.AddYears(-50), Name = "Shingtok Bindoya", ServedInOniwaban = false, ClanId = 1 }
            );
        }
    }
}
