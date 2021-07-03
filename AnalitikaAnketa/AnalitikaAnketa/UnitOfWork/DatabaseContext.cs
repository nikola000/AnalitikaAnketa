using System.Data.Entity;

namespace UnitOfWorkExample.UnitOfWork
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext() : base("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configuration here
        }
    }
}