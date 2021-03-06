using AnalitikaAnketa.UnitOfWork.Models;
using System.Data.Entity;
using UnitOfWorkExample.UnitOfWork.Models;

namespace UnitOfWorkExample.UnitOfWork
{
 
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DatabaseContext() : base("Server=localhost\\SQLEXPRESS;Database=AnalitikaAnketaDB;Trusted_Connection=True;")
        {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
            //Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configuration here            
        }
    }
}
