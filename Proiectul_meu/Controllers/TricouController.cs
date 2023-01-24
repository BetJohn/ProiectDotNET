using Microsoft.AspNetCore.Mvc;
using Proiectul_meu.Services;

namespace Proiectul_meu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TricouController : ControllerBase
    {
        public readonly ITricouService _tricouService;
        
        public TricouController(ITricouService tricouService)
        {
            _tricouService = tricouService;
        }
        
        
    }
}
