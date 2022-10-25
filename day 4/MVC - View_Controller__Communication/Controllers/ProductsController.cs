using Microsoft.AspNetCore.Mvc;
using MVC___View_Controller__Communication.Models;
namespace MVC___View_Controller__Communication.Controllers
{
    public class ProductsController : Controller
    {

        Products pobj = new Products();
        public IActionResult ShowProducts()
        {

            return View(pobj.GetAllProducts());
        }



        [HttpPost]
        public IActionResult ShowProducts(Products newProduct)
        {
            pobj.AddProduct(newProduct);
            return View(pobj.GetAllProducts());
        }
    }
}
