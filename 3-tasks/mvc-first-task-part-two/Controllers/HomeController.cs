using Microsoft.AspNetCore.Mvc;
using mvc_first_task.Context;
using mvc_first_task.Models;
using System.Data;
using System.Diagnostics;

namespace mvc_first_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SystaemContext _context;
        public HomeController(ILogger<HomeController> logger, SystaemContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var dataFromSession = HttpContext.Session.GetString("userInfo");

            if (dataFromSession is null)
                return RedirectToAction("Index", "Login");

            var dataFromCookies = Request.Cookies["role"];
            if (dataFromCookies == Role.Employee.ToString()) return RedirectToAction("EmployeeHomePage", "Employees");
            else return RedirectToAction("Index", "Managers");

        }

        public IActionResult Privacy()
        {
            Employees newEmployeeForTest = new Employees()
            {
                FirstName = "Abdulaziz",
                LastName = "AlHariri",
                Email = "abd1862342513@gmail.com",
                PhoneNumber = "1234567890",
                JobTitle = "Test",
                Salary = 100000,
                Address = "huarrara",
                DepartmentId = 123123,
                Department = new Department()
                {

                },
                EmployeeId = 0,
                Role = (int)Role.Manager,
            };
            _context.Employees.Add(newEmployeeForTest);
            _context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
