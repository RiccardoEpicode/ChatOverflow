using Microsoft.AspNetCore.Mvc;

namespace ChatOverflow.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
