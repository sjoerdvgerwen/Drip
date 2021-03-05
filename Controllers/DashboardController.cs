using Microsoft.AspNetCore.Mvc;

namespace Drip.Controllers
{
    public class DashboardController : Controller

    {
    public IActionResult Index()
    {
        return View();
    }
    }
}