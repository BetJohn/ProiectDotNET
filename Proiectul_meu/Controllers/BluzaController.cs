using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BluzaController : ControllerBase
    {
        public readonly IBluzaService _bluzaService;

        public BluzaController(IBluzaService bluzaService)
        {
            _bluzaService = bluzaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBluze()
        {
            var bluze = await _bluzaService.GetAllBluze();
            return Ok(bluze);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBluza(Guid id)
        {
            var bluza = await _bluzaService.GetBluzaById(id);
            return Ok(bluza);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateBluza([FromBody] BluzaDTO bluza)
        {
            await _bluzaService.CreateBluza(bluza);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateBluza([FromBody] BluzaDTO bluza)
        {
            await _bluzaService.UpdateBluza(bluza);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBluza(Guid id)
        {
            await _bluzaService.DeleteBluza(id);
            return Ok();
        }
    }
}
