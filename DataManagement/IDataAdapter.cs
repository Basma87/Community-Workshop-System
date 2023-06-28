using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
  public  interface IDataAdapter
    {
        List<Customer> GetAllCustomers();
        Customer getSingleCustomerDetails(int id);

       void saveExistinCustomer(Customer newCustomer);

        void SaveSingleCustomer(Customer newCustomer);

        void DeleteCustomer(int id);


    }
}
