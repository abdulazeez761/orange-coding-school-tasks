using Microsoft.AspNetCore.Mvc;

namespace LayOutProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
