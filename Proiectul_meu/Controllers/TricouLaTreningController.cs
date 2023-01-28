using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TricouLaTreningController : ControllerBase
    {
        public ITricouLaTreningService _tricouLaTreningService;

        public TricouLaTreningController(ITricouLaTreningService tricouLaTreningService)
        {
            _tricouLaTreningService = tricouLaTreningService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTricouLaTrening()
        {
            var TricouLaTrening = await _tricouLaTreningService.GetAllTricouLaTrening();
            return Ok(TricouLaTrening);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTricouLaTrening(Guid id)
        {
            var TricouLaTrening = await _tricouLaTreningService.GetTricouLaTreningById(id);
            return Ok(TricouLaTrening);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateTricouLaTrening([FromBody] TricouLaTreningDTO TricouLaTrening)
        {
            await _tricouLaTreningService.CreateTricouLaTrening(TricouLaTrening);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateTricouLaTrening([FromBody] TricouLaTreningDTO TricouLaTrening)
        {
            await _tricouLaTreningService.UpdateTricouLaTrening(TricouLaTrening);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTricouLaTrening(Guid id)
        {
            await _tricouLaTreningService.DeleteTricouLaTrening(id);
            return Ok();
        }
    }
}
