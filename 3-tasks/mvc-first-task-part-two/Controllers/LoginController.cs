using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_first_task.Context;
using mvc_first_task.Models;

namespace LoginUsingCookiesAndSessions.Controllers
{
    public class LoginController : Controller
    {
        private readonly SystaemContext _context;
        public LoginController(SystaemContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel formData)
        {


            var email = formData.Email;
            var member = await _context.Employees.Where(m => m.Email == email).ToListAsync();

            string role = member[0].Role.ToString();
            string firstName = member[0].FirstName;
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7),
                Secure = true,
                HttpOnly = true
            };
            Response.Cookies.Append("role", role, cookieOptions);
            HttpContext.Session.SetString("userInfo", firstName);
            if (role == Role.Employee.ToString()) return RedirectToAction("EmployeeHomePage", "Employees");
            else return RedirectToAction("Index", "Managers");
        }
        public async Task<IActionResult> LogOut(LoginViewModel formData)
        {


            Response.Cookies.Delete("role");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}
