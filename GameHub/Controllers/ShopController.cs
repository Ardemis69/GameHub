using GameHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Category(string Name)
        {
            //,ensure some category name was passed
            if (Name == null)
            {
                return RedirectToAction("Index");
            }

            //get the name parameter from the url and store in ViewData object so we can display object
            ViewData["Category"] = Name;

            //Use the product model to create the list of products in the memory to display
            var products = new List<Product>();
            //use a lopp to make some products
            for(var i =1; i<6; i++)
            {
                products.Add(new Product { ProductId=i, Name = "Product"+ i.ToString(), Price= 10+i });
            }
            //loading the page and pass it the product list to display
            return View(products);
        }
    }
}
