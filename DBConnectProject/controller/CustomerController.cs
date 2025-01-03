
using DBConnectProject.context;
using DBConnectProject.repository;
using DBConnectProject.service;

namespace DBConnectProject.controller
{
    internal class CustomerController
    {
        ICustomerService customerService;
        public CustomerController()
        {
            
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
