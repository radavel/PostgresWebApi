using Microsoft.EntityFrameworkCore;
using PostgresWebApi.Models;

namespace PostgresWebApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
    }
}