
using DBConnectProject.context;
using DBConnectProject.service;

namespace DBConnectProject.controller
{
    internal class CustomerController
    {
        ICustomerService customerService;
        public CustomerController()
        {
            customerService=new CustomerService(new DbBaglan());
        }

        public void save(string id,string compname,string contactName)
        {
            customerService.save(id,compname, contactName);
        }

        public bool update(string id,string name)
        {
           return customerService.update(id,name);
        }


    }
}
