using Microsoft.EntityFrameworkCore;

namespace mvc_rest_api.Models.Repositories.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Entities.Cliente> Clientes { get; set; }
    }
}
