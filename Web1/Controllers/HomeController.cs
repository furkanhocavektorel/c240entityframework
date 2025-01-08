using Microsoft.AspNetCore.Mvc;
using Web1.context;
using Web1.service;
using Web1.service.concrete;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
       
        private IProductService _productService;

        public HomeController()
        {
            _productService = new ProductService(new NorthwindDB());
        }


        public IActionResult Index()
        {
            Console.WriteLine("ooo kral hg");
            return View(_productService.getAllProducts());
        }
        // Product i�in categoriler getirilecek.
        // M��teri kayit edilece.REgister yap�lacak

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
