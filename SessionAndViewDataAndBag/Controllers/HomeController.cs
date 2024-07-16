using Microsoft.AspNetCore.Mvc;
using SessionAndViewDataAndBag.Models;
using System.Diagnostics;

namespace SessionAndViewDataAndBag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*ViewData["MyTime"] = DateTime.Now.ToString();*/
            ViewBag.MyTime = DateTime.Now.ToString(); // ViewBag is only a syntax shoger of viewdata

            /*view bag and view data can only send datat from controller to view what if I want to send dat from controller to another controller or action to action? 
             * TempData is the key
             * on important key is that temp data only services for only one request when I send anotehr request it becomes null
             * what If Iwant to to least as much as posseble? the key is session
             */
            /* TempData["MyTimeTemp"] = DateTime.Now.ToString();
             return RedirectToAction("Privacy");*/


            /*HttpContext.Session.SetString("MySessionData", DateTime.Now.ToString());*/
            return View();

        }


        public IActionResult Privacy()
        {
            // Retrieve Session data set in Index action
            /*    ViewData["SessionValue"] = HttpContext.Session.GetString("MySessionData");*/

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
