using AirlineReservationSystem.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories.Interfaces
{
    public interface IAirplaneRepository
    {
        Task<IEnumerable<Airplane>> GetAllAsync();
        Task<Airplane> GetByIdAsync(int id);
        Task AddAsync(Airplane airplane);
        Task UpdateAsync(Airplane airplane);
        Task DeleteAsync(int id);
    }
}
