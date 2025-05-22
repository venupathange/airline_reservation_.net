using AirlineReservationSystem.Models;
using AirlineReservationSystem.Repositories.Interfaces;
using AirlineReservationSystem.Services.Interfaces;

namespace AirlineReservationSystem.Services.Implementations
{
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _repository;

        public AirportService(IAirportRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Airport>> GetAllAirportsAsync() => _repository.GetAllAsync();

        public Task<Airport?> GetAirportByIdAsync(int id) => _repository.GetByIdAsync(id);

        public Task AddAirportAsync(Airport airport) => _repository.AddAsync(airport);

        public Task DeleteAirportAsync(int id) => _repository.DeleteAsync(id);
    }
}
