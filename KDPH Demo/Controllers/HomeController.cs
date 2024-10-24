using KDPH_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
/*Added for sync Testing*/
/*Added for sync Testing from github to devops new*/
/*Added for sync Testing from github to devops*/
/*Test auto trigger*/
namespace KDPH_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
