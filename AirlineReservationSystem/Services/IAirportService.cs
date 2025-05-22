using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.Services.Interfaces
{
    public interface IAirportService
    {
        Task<IEnumerable<Airport>> GetAllAirportsAsync();
        Task<Airport?> GetAirportByIdAsync(int id);
        Task AddAirportAsync(Airport airport);
        Task DeleteAirportAsync(int id);
    }
}
