

using DBConnectProject.context;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.repository
{
    internal class CrudRepository<T,ID> : IRepository<T,ID> where T : class
    {
        DbBaglan dbBaglan;

        DbSet<T> dbbaglantablolar;

        public CrudRepository()
        {
            // TODO : yanlis sekilde birakıyorum const metodu talep etmeli.
            dbBaglan = new DbBaglan();
            dbbaglantablolar = dbBaglan.Set<T>();
        }

        public void add(T x)
        {
            dbbaglantablolar.Add(x);
            dbBaglan.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbbaglantablolar.ToList();
           
        }

        public T getById(ID id)
        {
            return dbbaglantablolar.Find(id);
        }

        public void remove(T x)
        {
            throw new NotImplementedException();
        }

        public void update(T entity, ID id)
        {
            throw new NotImplementedException();
        }


    }
}
