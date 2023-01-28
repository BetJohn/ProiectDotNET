using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoseteController : ControllerBase
    {
        public ISoseteService _soseteService;

        public SoseteController(ISoseteService soseteService)
        {
            _soseteService = soseteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSosete()
        {
            var Sosete = await _soseteService.GetAllSosete();
            return Ok(Sosete);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSosete(Guid id)
        {
            var Sosete = await _soseteService.GetSoseteById(id);
            return Ok(Sosete);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateSosete([FromBody] SoseteDTO Sosete)
        {
            await _soseteService.CreateSosete(Sosete);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateSosete([FromBody] SoseteDTO Sosete)
        {
            await _soseteService.UpdateSosete(Sosete);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSosete(Guid id)
        {
            await _soseteService.DeleteSosete(id);
            return Ok();
        }
    }
}
