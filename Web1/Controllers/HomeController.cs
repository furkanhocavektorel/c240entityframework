using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web1.Models;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            List<ProductModel> productList = new List<ProductModel>();

            ProductModel model = new ProductModel();
            model.Ad = "telefon";
            model.Fiyat = 30000;
            model.Stok = 14;

            ProductModel model2 = new ProductModel();
            model2.Ad = "laptop";
            model2.Fiyat = 54523;
            model2.Stok = 15;


            ProductModel model3 = new ProductModel();
            model3.Ad = "laptop2";
            model3.Fiyat = 534523;
            model3.Stok = 152;

            productList.Add(model);
            productList.Add(model2);
            productList.Add(model3);



            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
