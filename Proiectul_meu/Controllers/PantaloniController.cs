using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantaloniController : ControllerBase
    {
        public readonly IPantaloniService _pantaloniService;

        public PantaloniController(IPantaloniService pantaloniService)
        {
            _pantaloniService = pantaloniService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPantaloni()
        {
            var pantaloni = await _pantaloniService.GetAllPantaloni();
            return Ok(pantaloni);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPantaloni(Guid id)
        {
            var pantaloni = await _pantaloniService.GetPantaloniById(id);
            return Ok(pantaloni);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreatePantaloni([FromBody] PantaloniDTO pantaloni)
        {
            await _pantaloniService.CreatePantaloni(pantaloni);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdatePantaloni([FromBody] PantaloniDTO pantaloni)
        {
            await _pantaloniService.UpdatePantaloni(pantaloni);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePantaloni(Guid id)
        {
            await _pantaloniService.DeletePantaloni(id);
            return Ok();
        }
    }
}
