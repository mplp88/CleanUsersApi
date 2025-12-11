using Microsoft.EntityFrameworkCore;
using Pon.CleanUsers.Application.Interfaces;
using Pon.CleanUsers.Domain.Entities;
using Pon.CleanUsers.Infrastructure.Data;

namespace Pon.CleanUsers.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        public async Task<List<User>> GetAllAsync() =>
            await context.Users.ToListAsync();

        public async Task<User?> GetByIdAsync(int id) =>
            await context.Users.FindAsync(id);

        public async Task<User> AddAsync(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }
    }
}
