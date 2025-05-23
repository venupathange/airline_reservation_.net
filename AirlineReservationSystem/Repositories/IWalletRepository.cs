using AirlineReservationSystem.Data.Entities;

namespace AirlineReservationSystem.Data.Repositories
{
    public interface IWalletRepository
    {
        Task<IEnumerable<Wallet>> GetAllAsync();
        Task<Wallet?> GetByIdAsync(int id);
        Task<Wallet?> GetByUserIdAsync(int userId);
        Task<Wallet> AddAsync(Wallet wallet);
        Task<Wallet> UpdateAsync(Wallet wallet);
        Task<bool> DeleteAsync(int id);
    }
}
