using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SchoolAppMvcsCore.Context;
using SchoolAppMvcsCore.Models;
using System.Security.Claims;

public class AccountController : Controller
{
    private readonly SchoolContext _context;

    public AccountController(SchoolContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginModel model)
    {

        var teacher = _context.Teachers
          .Where(t => t.TeacherName == model.UserName && t.Role == "Teacher")
          .Select(t => new { UserName = t.TeacherName, Role = "Teacher" })
          .FirstOrDefault();

        // Check for the student
        var student = teacher == null
            ? _context.Students
                .Where(s => s.StudentName == model.UserName && s.Role == "Student")
                .Select(s => new { UserName = s.StudentName, Role = "Student" })
                .FirstOrDefault()
            : null;

        var user = teacher ?? student;


        if (user != null)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.UserName),
                    new Claim(ClaimTypes.Role, user.Role)
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            if (user.Role == "Teacher")
            {
                //return RedirectToAction("Index", "Teacher"); // Redirect to Teacher dashboard
                return RedirectToAction("Index", "Home"); // Redirect to Teacher dashboard
            }
            else
            {
                //return RedirectToAction("Index", "Student"); // Redirect to Student dashboard
                return RedirectToAction("Index", "Home"); // Redirect to Student dashboard
            }
        }

        ModelState.AddModelError("", "Invalid login attempt");


        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }
    [HttpGet]
    public IActionResult AccessDenied()
    {
        return View();
    }
}
