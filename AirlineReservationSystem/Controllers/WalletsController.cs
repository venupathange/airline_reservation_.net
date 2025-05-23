using AirlineReservationSystem.Data.Entities;
using AirlineReservationSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletsController : ControllerBase
    {
        private readonly IWalletService _service;

        public WalletsController(IWalletService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var wallet = await _service.GetByIdAsync(id);
            return wallet == null ? NotFound() : Ok(wallet);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var wallet = await _service.GetByUserIdAsync(userId);
            return wallet == null ? NotFound() : Ok(wallet);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Wallet wallet)
        {
            var created = await _service.AddAsync(wallet);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Wallet wallet)
        {
            if (id != wallet.Id) return BadRequest();

            var updated = await _service.UpdateAsync(wallet);
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
