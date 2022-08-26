using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using TestApp.Models;
using Task = TestApp.Models.Task;

namespace TestApp.DAL
{
    public class AppContext : DbContext
    {

        public AppContext() : base("AppContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
