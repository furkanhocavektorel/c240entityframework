using Web1.entity;
using Web1.Models;

namespace Web1.service
{
    public interface IProductService
    {
        List<ProductModel> getAllProducts(int? id);
    }
}
