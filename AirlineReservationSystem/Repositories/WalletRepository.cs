using AirlineReservationSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem.Data.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly AppDbContext _context;

        public WalletRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Wallet>> GetAllAsync()
        {
            return await _context.Wallets.ToListAsync();
        }

        public async Task<Wallet?> GetByIdAsync(int id)
        {
            return await _context.Wallets.FindAsync(id);
        }

        public async Task<Wallet?> GetByUserIdAsync(int userId)
        {
            return await _context.Wallets.FirstOrDefaultAsync(w => w.UserId == userId);
        }

        public async Task<Wallet> AddAsync(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            await _context.SaveChangesAsync();
            return wallet;
        }

        public async Task<Wallet> UpdateAsync(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            await _context.SaveChangesAsync();
            return wallet;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var wallet = await _context.Wallets.FindAsync(id);
            if (wallet == null) return false;

            _context.Wallets.Remove(wallet);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
