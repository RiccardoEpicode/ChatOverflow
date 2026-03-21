using Microsoft.AspNetCore.Mvc;

namespace ChatOverflow.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult RegisterPage()
        {
            return View();
        }
    }
}
