using Microsoft.AspNetCore.Mvc;
using MVCDemoMuishMulla.Models;
using System.Diagnostics;

namespace MVCDemoMuishMulla.Controllers
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
            ViewBag.MyTitle = "Gopi's Dotnet Session";
            Student student = new Student()
            {
                Rno = 1,
                Name = "Suresh",
                Rank = 1
            };



            return View("Privacy", student);
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