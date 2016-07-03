namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShop.Context.MainDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebShop.Context.MainDbContext context)
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
            context.Products.Add(new Models.Product { Name = "Kalesony", Description = "Firmy sony", SellPrice = 45.99m });
            context.Products.Add(new Models.Product { Name = "Batonik czekoladowy", Description = "Taki super batonik super bardzo. Polecam.", SellPrice = 5.99m });
            context.Products.Add(new Models.Product { Name = "Powid³a", Description = "Tak bardzo œliwkowe...", SellPrice = 1.99m });
        }
    }
}
