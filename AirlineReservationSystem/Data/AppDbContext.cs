using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Airport> Airports { get; set; } // ✅ MUST be DbSet<Airport>

        // Add other DbSets here as needed
        public DbSet<Airplane> Airplanes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>(entity =>
            {
                entity.ToTable("AIRPLANES");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.AirplaneNumber).HasColumnName("AirplaneNumber");
                entity.Property(e => e.Model).HasColumnName("Model");
                entity.Property(e => e.TotalSeats).HasColumnName("TotalSeats");
                entity.Property(e => e.EconomySeats).HasColumnName("EconomySeats");
                entity.Property(e => e.BusinessSeats).HasColumnName("BusinessSeats");
            });
        }

    }
}
