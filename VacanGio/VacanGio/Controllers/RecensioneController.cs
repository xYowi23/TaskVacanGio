using Microsoft.AspNetCore.Mvc;

namespace VacanGio.Controllers
{
    public class Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
