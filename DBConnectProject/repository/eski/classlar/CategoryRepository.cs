using DBConnectProject.context;
using DBConnectProject.entity;
using DBConnectProject.repository.eski;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.repository.eski.classlar
{
    internal class CategoryRepository : ICategoryRepository
    {
        private DbBaglan dbBaglan;

        public void add(Category x)
        {
            dbBaglan.Categories.Add(x);
            dbBaglan.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return dbBaglan.Categories.ToList();
        }

        public Category getById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void remove(Category x)
        {
            throw new NotImplementedException();
        }

        public void update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
