using GYMLife.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GYMLife.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ClassDetails()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }     
        public IActionResult ClassTimeTable()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
       
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
        public IActionResult Erorr()
        {
            return View();
        }
        public IActionResult Contact()
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