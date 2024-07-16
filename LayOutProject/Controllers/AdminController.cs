using Microsoft.AspNetCore.Mvc;

namespace LayOutProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
