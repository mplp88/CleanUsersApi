using Microsoft.EntityFrameworkCore;
using Pon.CleanUsers.Domain.Entities;

namespace Pon.CleanUsers.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
    }
}
