
using DBConnectProject.context;
using DBConnectProject.entity;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.service
{
    internal class CustomerService : ICustomerService
    {
        DbBaglan d;

        public CustomerService(DbBaglan db)
        {
            d= db;
        }


        public void save(string id, string companyName, string customerName)
        {
            Customers c = 
                d.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));

            if (c != null)
            {
                return;
            }
            Customers customer = new Customers();
            customer.CustomerId = id;
            customer.CompanyName = companyName;
            customer.ContactName = customerName;

            d.Customers.Add(customer);
            d.SaveChanges();
        }

        public bool update(string id, string contactName)
        {
            Customers customer=d.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));

            if (customer == null)
            {
                return false;
            }
            else
            {
                customer.ContactName= contactName;
                d.Customers.Update(customer);
                d.SaveChanges() ;
                return true;

            }
            
        }
    }
}
