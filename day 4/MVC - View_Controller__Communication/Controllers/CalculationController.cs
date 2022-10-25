using Microsoft.AspNetCore.Mvc;

namespace MVC___View_Controller__Communication.Controllers
{
    public class CalculationController : Controller
    {

        [HttpGet] //this is by default and u do not need to set this
        public IActionResult Greetings()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Greetings(string txtguestName)
        {
            ViewBag.message = "Hello and Welcome to MVC " + txtguestName;
            return View();
        }

        [HttpGet]
        public IActionResult Calculate()
        {
            ViewBag.errMessage = "";
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int firstNum, int secondNum)
        {

            if (firstNum == 0 || secondNum == 0)
            {
                ViewBag.errMessage = "Please Enter Only Positive Numbers";
            }
            else if (firstNum < secondNum)
            {
                ViewBag.errMessage = "This will result in negative value";
            }
            else if (secondNum == 0)
            {
                ViewBag.errMessage = "We cannot divide a number with 0, this please put the second number greater than 1";
            }
            else
            {
                ViewBag.addition = firstNum + secondNum;
                ViewBag.subtraction = firstNum - secondNum;
                ViewBag.division = firstNum / secondNum;
                ViewBag.multiplication = firstNum * secondNum;
            }
            return View();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
