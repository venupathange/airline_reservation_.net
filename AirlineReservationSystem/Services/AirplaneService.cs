using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Repositories.Interfaces;
using AirlineReservationSystem.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Services.Implementations
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IAirplaneRepository _repository;

        public AirplaneService(IAirplaneRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Airplane>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Airplane> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Airplane airplane) => _repository.AddAsync(airplane);
        public Task UpdateAsync(Airplane airplane) => _repository.UpdateAsync(airplane);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}
