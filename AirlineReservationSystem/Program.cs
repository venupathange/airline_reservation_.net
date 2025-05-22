using AirlineReservationSystem.Data;
using AirlineReservationSystem.Services.Interfaces;
using AirlineReservationSystem.Services.Implementations;
using AirlineReservationSystem.Repositories.Interfaces;
using AirlineReservationSystem.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("OracleDb");
if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("Oracle connection string 'OracleDb' is not configured in appsettings.json");
}

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(connectionString));

// Register repository
builder.Services.AddScoped<IAirportRepository, AirportRepository>();
builder.Services.AddScoped<IAirplaneRepository, AirplaneRepository>();
// Register service
builder.Services.AddScoped<IAirportService, AirportService>();
builder.Services.AddScoped<IAirplaneService, AirplaneService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
