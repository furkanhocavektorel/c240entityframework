using System.Collections.Generic;
using Web1.context;
using Web1.entity;
using Web1.Models;

namespace Web1.service.concrete
{
    public class ProductService : IProductService
    {
        private NorthwindDB _northwindDB;

        public ProductService(NorthwindDB northwindDB)
        {
            _northwindDB = northwindDB;
        }

        public List<ProductModel> getAllProducts(int? id)
        {
            List<Product> products = new List<Product>();

            if (id == null)
            {
                products= _northwindDB.Products.ToList();
            }
            else
            {
                products = _northwindDB.Products
                    .Where(product=> product.Category.CategoryID== id).ToList();
            }


            List<ProductModel> productsModel = new List<ProductModel>();

            foreach (Product item in products)
            {
                ProductModel productModel= new ProductModel();

                productModel.Fiyat = item.UnitPrice;
                productModel.Name = item.ProductName;
                productModel.Stock = item.UnitsInStock;
                productsModel.Add(productModel);
                
            }
            int sayfaSayisi=products.Count / 50;
            Console.WriteLine(sayfaSayisi);

            productsModel = productsModel.Take(15)
                .OrderByDescending(x => x.Name)
                .ToList();

            return productsModel;          
        }


    }
}
