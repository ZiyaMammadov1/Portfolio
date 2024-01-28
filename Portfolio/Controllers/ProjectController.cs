using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Cabinet()
        {
            return View();
        }

        public IActionResult KBC()
        {
            return View();
        }

        public IActionResult Judge()
        {
            return View();
        }
    }
}
