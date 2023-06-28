using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class TestAdapter : IDataAdapter
    {
        
        public void DeleteCustomer(int id)
        {
            
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> newCustomers = new List<Customer>();
            newCustomers.Add(new Customer { LastName = "Gomaa", FirstName = "Basma", Phone = "12354558" });
            newCustomers.Add(new Customer { LastName = "elshiekh", FirstName = "kareem", Phone = "564789452" });

            return newCustomers;
        }

        public Customer getSingleCustomerDetails(int id)
        {
            return new Customer { LastName = "elshiekh", FirstName = "kareem", Phone = "564789452" };
        }

        public void saveExistinCustomer(Customer newCustomer)
        {
           
        }

        public void SaveSingleCustomer(Customer newCustomer)
        {
           
        }
    }
}
