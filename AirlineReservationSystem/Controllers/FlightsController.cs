using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _service;

        public FlightsController(IFlightService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var flight = await _service.GetByIdAsync(id);
            return flight == null ? NotFound() : Ok(flight);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Flight flight)
        {
            var created = await _service.AddAsync(flight);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Flight flight)
        {
            if (id != flight.Id) return BadRequest();
            var updated = await _service.UpdateAsync(flight);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result ? NoContent() : NotFound();
        }
    }
}
