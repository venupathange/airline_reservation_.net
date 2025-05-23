using AirlineReservationSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            // Fix: Cast _context.Users to DbSet<User> to resolve the issue
            return await ((DbSet<User>)_context.Users).ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await ((DbSet<User>)_context.Users).FindAsync(id);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await ((DbSet<User>)_context.Users).FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> AddAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            await ((DbSet<User>)_context.Users).AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            ((DbSet<User>)_context.Users).Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await ((DbSet<User>)_context.Users).FindAsync(id);
            if (user == null) return false;

            ((DbSet<User>)_context.Users).Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
