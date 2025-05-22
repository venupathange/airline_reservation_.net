using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories.Interfaces
{
    public interface IAirportRepository
    {
        Task<IEnumerable<Airport>> GetAllAsync();
        Task<Airport?> GetByIdAsync(int id);
        Task AddAsync(Airport airport);
        Task UpdateAsync(Airport airport); // <- Make sure this exists
        Task DeleteAsync(int id);
    }
}
