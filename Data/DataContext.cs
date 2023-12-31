using CitasAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitasAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
