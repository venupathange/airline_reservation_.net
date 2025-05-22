using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneService _service;

        public AirplaneController(IAirplaneService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Airplane>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Airplane>> Get(int id)
        {
            var airplane = await _service.GetByIdAsync(id);
            if (airplane == null) return NotFound();
            return airplane;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Airplane airplane)
        {
            await _service.AddAsync(airplane);
            return CreatedAtAction(nameof(Get), new { id = airplane.Id }, airplane);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Airplane airplane)
        {
            if (id != airplane.Id) return BadRequest();
            await _service.UpdateAsync(airplane);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
