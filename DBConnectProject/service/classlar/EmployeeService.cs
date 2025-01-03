using DBConnectProject.entity;
using DBConnectProject.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.service.classlar
{
    internal class EmployeeService
    {
        EmployeeRepository employeeRepository;
        Customer2Repository customerRepository;
        public EmployeeService() {
            // YAnlis
            employeeRepository = new EmployeeRepository();
            customerRepository = new Customer2Repository();

        }

        public void save(int id,string ad,string soyad)
        {
            Employee employee = new Employee();

            employee.EmployeeID = id;
            employee.FirstName = ad;
            employee.LastName = soyad;

            employeeRepository.add(employee);


        }

        public List<Employee> findAll()
        {
            return employeeRepository.GetAll();
        }

        public List<Customers> GetCustomers() { 
        
            return customerRepository.GetAll();

        }




    }
}
