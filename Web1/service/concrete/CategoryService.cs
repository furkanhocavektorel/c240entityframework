using Web1.context;
using Web1.entity;
using Web1.Models;

namespace Web1.service.concrete
{
    public class CategoryService : ICategoryService
    {
        private NorthwindDB _dB;
        public CategoryService(NorthwindDB db)
        {
            _dB = db;
        }
        public List<CategoryModel> GetAll()
        {

            List<CategoryModel> categoryModels = new List<CategoryModel>();

            foreach (Category category in _dB.Categories.ToList())
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.id = category.CategoryID;
                categoryModel.CategoryName = category.CategoryName;
                categoryModels.Add(categoryModel);
            }

            return categoryModels;
        }
    }
}
