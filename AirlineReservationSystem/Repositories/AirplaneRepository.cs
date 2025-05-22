using AirlineReservationSystem.Data;
using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories.Implementations
{
    public class AirplaneRepository : IAirplaneRepository
    {
        private readonly AppDbContext _context;

        public AirplaneRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Airplane>> GetAllAsync()
        {
            return await _context.Airplanes.ToListAsync();
        }

        public async Task<Airplane> GetByIdAsync(int id)
        {
            return await _context.Airplanes.FindAsync(id);
        }

        public async Task AddAsync(Airplane airplane)
        {
            _context.Airplanes.Add(airplane);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Airplane airplane)
        {
            _context.Entry(airplane).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var airplane = await _context.Airplanes.FindAsync(id);
            if (airplane != null)
            {
                _context.Airplanes.Remove(airplane);
                await _context.SaveChangesAsync();
            }
        }
    }
}
