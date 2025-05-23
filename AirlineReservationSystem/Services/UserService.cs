using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Data.Repositories;

namespace AirlineReservationSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<User?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<User?> GetByEmailAsync(string email) => await _repository.GetByEmailAsync(email);

        public async Task<User> AddAsync(User user) => await _repository.AddAsync(user);

        public async Task<User> UpdateAsync(User user) => await _repository.UpdateAsync(user);

        public async Task<bool> DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}