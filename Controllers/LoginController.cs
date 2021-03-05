using Microsoft.AspNetCore.Mvc;

namespace Drip.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}