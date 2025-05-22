using AirlineReservationSystem.Models;
using AirlineReservationSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _service;

        public AirportController(IAirportService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var airports = await _service.GetAllAirportsAsync();
            return Ok(airports);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var airport = await _service.GetAirportByIdAsync(id);
            if (airport == null) return NotFound();
            return Ok(airport);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Airport airport)
        {
            await _service.AddAirportAsync(airport);
            return Ok(airport);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAirportAsync(id);
            return NoContent();
        }
    }
}
