using DBConnectProject.entity;
using DBConnectProject.repository.eski;

namespace DBConnectProject.service.classlar
{
    internal class CategoryService : ICategoryService
    {
        ICategoryRepository repository;

        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public void CreateCategory(int id, string name, string desc)
        {

            
        }
    }
}
