using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreningController : ControllerBase
    {
        public ITreningService _treningService;

        public TreningController(ITreningService treningService)
        {
            _treningService = treningService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrening()
        {
            var Trening = await _treningService.GetAllTreninguri();
            return Ok(Trening);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrening(Guid id)
        {
            var Trening = await _treningService.GetTreningById(id);
            return Ok(Trening);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateTrening([FromBody] TreningDTO Trening)
        {
            await _treningService.CreateTrening(Trening);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateTrening([FromBody] TreningDTO Trening)
        {
            await _treningService.UpdateTrening(Trening);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrening(Guid id)
        {
            await _treningService.DeleteTrening(id);
            return Ok();
        }
    }
}
