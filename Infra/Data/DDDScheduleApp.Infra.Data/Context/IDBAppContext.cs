using DDDScheduleApp.Entities;
using Microsoft.Data.Entity;

namespace DDDScheduleApp.Infra.Data.Context
{
    public interface IDBAppContext
    {
        DbSet<Client> Clients { get; set; }
    }
}
