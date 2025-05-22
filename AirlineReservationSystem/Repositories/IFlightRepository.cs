using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.Data.Repositories
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>> GetAllAsync();
        Task<Flight?> GetByIdAsync(int id);
        Task<Flight> AddAsync(Flight flight);
        Task<Flight> UpdateAsync(Flight flight);
        Task<bool> DeleteAsync(int id);
    }
}