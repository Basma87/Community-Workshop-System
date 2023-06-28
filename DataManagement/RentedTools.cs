using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

namespace DataManagement
{
  public  class RentedTools 
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int Tool_ID { get; set; }

        public DateTime Rented_Date { get; set; }
        public DateTime? Returned_Date { get; set; }

        public RentedTools()
        {
        }

        public RentedTools(int customerID, int toolID, DateTime rented)
        {
            CustomerID = customerID;
            Tool_ID = toolID;
            Rented_Date = rented;


        }
    }
}
