namespace MVCEntityFrameworkCodeFirst.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class MVCEFCodeFirstDbContext : DbContext
    {
        // Your context has been configured to use a 'MVCEFCodeFirstDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCEntityFrameworkCodeFirst.Models.MVCEFCodeFirstDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MVCEFCodeFirstDbContext' 
        // connection string in the application configuration file.
        public MVCEFCodeFirstDbContext()
            : base("name=MVCEFCodeFirstDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<LoginEntity> LoginEntities { get; set; }
    }

    public class LoginEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Enter Username")]
        public string UserName { get; set; }

        [Display(Name ="Enter Password")]
        public string Password { get; set; }        
    }
}