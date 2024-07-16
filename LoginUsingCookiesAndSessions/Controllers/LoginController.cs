using LoginUsingCookiesAndSessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginUsingCookiesAndSessions.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel formData)
        {
            if (ModelState.IsValid)
            {
                var username = formData.Username;
                var password = formData.Password;
                var rememberMe = formData.RememberMe;


                if (rememberMe)
                {
                    var cookieOptions = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(7),
                        Secure = true,
                        HttpOnly = true
                    };
                    Response.Cookies.Append("userInfo", username, cookieOptions);
                }
                else
                {
                    HttpContext.Session.SetString("userInfo", username);
                }

                return RedirectToAction("Info");

            }

            return View(formData);
        }

        public IActionResult Info()
        {
            var dataFromCookies = Request.Cookies["userInfo"];
            var dataFromSession = HttpContext.Session.GetString("userInfo");

            if (dataFromCookies != null || dataFromSession is not null)
            {
                ViewData["userName"] = dataFromCookies ?? dataFromSession;
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}
