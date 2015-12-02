using DDDScheduleApp.Entities;
using Microsoft.Data.Entity;

namespace DDDScheduleApp.Infra.Data.Context
{
    public class DBAppContext : DbContext, IDBAppContext
    {
        public virtual DbSet<Client> Clients { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = @"Server=localhost; Port=5432; User Id=volt; Password=vlwMASTERpwd; Database=DDDScheduleApp";
            builder.UseNpgsql(connectionString);
        }		
    }	
}

