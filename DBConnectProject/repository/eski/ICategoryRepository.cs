using DBConnectProject.entity;

namespace DBConnectProject.repository.eski
{
    internal interface ICategoryRepository : IRepository<Category, int>
    {
        Category GetCategory(string categoryName);
    }
}
