using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Data.Repositories;

namespace AirlineReservationSystem.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _repository;

        public WalletService(IWalletRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Wallet>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<Wallet?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Wallet?> GetByUserIdAsync(int userId) => await _repository.GetByUserIdAsync(userId);

        public async Task<Wallet> AddAsync(Wallet wallet) => await _repository.AddAsync(wallet);

        public async Task<Wallet> UpdateAsync(Wallet wallet) => await _repository.UpdateAsync(wallet);

        public async Task<bool> DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
