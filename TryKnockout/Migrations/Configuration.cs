using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
namespace TryKnockout.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<TryKnockout.DAL.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TryKnockout.DAL.BookContext";
        }

        protected override void Seed(TryKnockout.DAL.BookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

           
        }
    }
}
