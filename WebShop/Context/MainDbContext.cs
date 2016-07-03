namespace WebShop.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MainDbContext : DbContext
    {
        // Your context has been configured to use a 'MainDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebShop.Context.MainDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MainDbContext' 
        // connection string in the application configuration file.
        public MainDbContext()
            : base("name=MainDbConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        
    }
}