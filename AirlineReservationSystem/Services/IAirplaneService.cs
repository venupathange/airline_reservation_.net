using AirlineReservationSystem.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Services.Interfaces
{
    public interface IAirplaneService
    {
        Task<IEnumerable<Airplane>> GetAllAsync();
        Task<Airplane> GetByIdAsync(int id);
        Task AddAsync(Airplane airplane);
        Task UpdateAsync(Airplane airplane);
        Task DeleteAsync(int id);
    }
}
