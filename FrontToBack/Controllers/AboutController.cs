using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
