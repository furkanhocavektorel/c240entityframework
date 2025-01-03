using DBConnectProject.context;
using DBConnectProject.entity;


namespace DBConnectProject.repository.eski.classlar
{
    internal class CustomerRepository : IRepository<Customers, string>
    {
        private DbBaglan dbBaglan;

        public CustomerRepository()
        {
            dbBaglan = new DbBaglan();

        }

        public void add(Customers x)
        {

            dbBaglan.Customers.Add(x);
            dbBaglan.SaveChanges();

        }

        public List<Customers> GetAll()
        {
            return dbBaglan.Customers.ToList();
        }

        public Customers getById(string id)
        {
            return dbBaglan.Customers
                .FirstOrDefault(x => x.CustomerId.Equals(id));
        }

        public void remove(Customers x)
        {
            dbBaglan.Customers.Remove(x);
        }

        public void update(Customers entity, string id)
        {

            Customers customers = getById(id);

            customers.ContactName = entity.ContactName;
            customers.City = entity.City;
            customers.Fax = entity.Fax;

            dbBaglan.Update(customers);
            dbBaglan.SaveChanges();

        }



    }
}
