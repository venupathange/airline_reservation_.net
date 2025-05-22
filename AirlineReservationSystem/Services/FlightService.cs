
using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Data.Repositories;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _repository;

        public FlightService(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Flight>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<Flight?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Flight> AddAsync(Flight flight) => await _repository.AddAsync(flight);

        public async Task<Flight> UpdateAsync(Flight flight) => await _repository.UpdateAsync(flight);

        public async Task<bool> DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}