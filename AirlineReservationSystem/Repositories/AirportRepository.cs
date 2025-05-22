﻿using AirlineReservationSystem.Data;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem.Repositories.Implementations
{
    public class AirportRepository : IAirportRepository
    {
        private readonly AppDbContext _context;

        public AirportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Airport>> GetAllAsync()
        {
            return await _context.Airports.ToListAsync();
        }

        public async Task<Airport?> GetByIdAsync(int id)
        {
            return await _context.Airports.FindAsync(id);
        }

        public async Task AddAsync(Airport airport)
        {
            await _context.Airports.AddAsync(airport);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Airport airport)
        {
            _context.Airports.Update(airport);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var airport = await _context.Airports.FindAsync(id);
            if (airport != null)
            {
                _context.Airports.Remove(airport);
                await _context.SaveChangesAsync();
            }
        }
    }
}
