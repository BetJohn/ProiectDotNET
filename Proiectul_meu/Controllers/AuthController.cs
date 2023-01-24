using Microsoft.AspNetCore.Mvc;

namespace Proiectul_meu.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
