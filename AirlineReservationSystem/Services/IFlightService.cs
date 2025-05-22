
using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.Services
{
    public interface IFlightService
    {
        Task<IEnumerable<Flight>> GetAllAsync();
        Task<Flight?> GetByIdAsync(int id);
        Task<Flight> AddAsync(Flight flight);
        Task<Flight> UpdateAsync(Flight flight);
        Task<bool> DeleteAsync(int id);
    }
}