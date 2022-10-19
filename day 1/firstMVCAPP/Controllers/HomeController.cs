using firstMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using firstMVCAPP.Models;

namespace firstMVCAPP.Controllers
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
        EmployeeDetailsModel empObj = new EmployeeDetailsModel();
        public IActionResult ShowEmployeeDetails()
        {
            
            ViewBag.empDetails = empObj.GetAllEmployee();
            return View();
        }

        public IActionResult About()
        {
            ViewBag.appName = "First MVC APP";
            ViewBag.developer = "Nikhil Shah";
            ViewBag.teamSize = 15;
            ViewBag.teamMembers = new List<string>() 
            {
                "Nikhil", 
                "Naveen",
                "SriLaxmi", 
                "Matthew",
                "Janhavi",
                "Namrata" 
            };
            return View();
        }

        public IActionResult ContactUs()
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