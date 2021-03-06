using System;
using System.Data.Entity;
using System.Linq;

namespace KanbanSample.Models
{
    public class ApplicationDBConext : DbContext
    {
        // Your context has been configured to use a 'ApplicationDBConext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KanbanSample.Models.ApplicationDBConext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApplicationDBConext' 
        // connection string in the application configuration file.
        public ApplicationDBConext()
            : base("name=ApplicationDBConext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Models.Person> People { get; set; }
         public virtual DbSet<Models.PersonState> PersonStates { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}