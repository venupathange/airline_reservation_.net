using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Airport> Airports { get; set; } // ✅ MUST be DbSet<Airport>
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("FLIGHTS");

                entity.HasKey(f => f.Id);

                entity.Property(f => f.Id)
                      .HasColumnName("Id");

                entity.Property(f => f.FlightName)
                      .HasColumnName("FlightName")
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(f => f.AirplaneId)
                      .HasColumnName("AirplaneId")
                      .IsRequired();

                entity.Property(f => f.SourceAirportId)
                      .HasColumnName("SourceAirportId")
                      .IsRequired();

                entity.Property(f => f.DestinationAirportId)
                      .HasColumnName("DestinationAirportId")
                      .IsRequired();

                entity.Property(f => f.DepartureTime)
                      .HasColumnName("DepartureTime")
                      .IsRequired();

                entity.Property(f => f.ArrivalTime)
                      .HasColumnName("ArrivalTime")
                      .IsRequired();

                entity.Property(f => f.Status)
                      .HasColumnName("Status")
                      .HasMaxLength(20)
                      .IsRequired();

                // ❌ No foreign key relationships configured
            });
        }
    }
}
