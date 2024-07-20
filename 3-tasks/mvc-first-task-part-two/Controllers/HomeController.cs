using Microsoft.AspNetCore.Mvc;
using mvc_first_task.ActionFilters;
using mvc_first_task.Context;
using mvc_first_task.Models;
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

        [MultipleRoles("Manager", "Employee")]
        public IActionResult Index()
        {

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
                    DepartmentId = 1,
                    DepartmentName = "Test",

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
