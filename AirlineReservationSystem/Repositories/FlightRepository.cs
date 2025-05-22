using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly AppDbContext _context;

        public FlightRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Flight>> GetAllAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public async Task<Flight?> GetByIdAsync(int id)
        {
            return await _context.Flights.FindAsync(id);
        }

        public async Task<Flight> AddAsync(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
            return flight;
        }

        public async Task<Flight> UpdateAsync(Flight flight)
        {
            _context.Flights.Update(flight);
            await _context.SaveChangesAsync();
            return flight;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var flight = await _context.Flights.FindAsync(id);
            if (flight == null) return false;

            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}