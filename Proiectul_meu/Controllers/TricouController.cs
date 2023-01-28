using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class TricouController : ControllerBase
    {
        public readonly ITricouService _tricouService;
        
        public TricouController(ITricouService tricouService)
        {
            _tricouService = tricouService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTricouri()
        {
            var tricouri = await _tricouService.GetAllTricouri();
            return Ok(tricouri);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTricou(Guid id)
        {
            var tricou = await _tricouService.GetTricouById(id);
            return Ok(tricou);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateTricou([FromBody] TricouDTO tricou)
        {
            await _tricouService.CreateTricou(tricou);
            return Ok();
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateTricou([FromBody] TricouDTO tricou)
        {
            await _tricouService.UpdateTricou(tricou);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTricou(Guid id)
        {
            await _tricouService.DeleteTricou(id);
            return Ok();
        }
    }
}
