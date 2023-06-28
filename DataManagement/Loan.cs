using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class Loan
    {
        public int RentID { get; set; }
        public int CustomerID { get; set; }
        public int Tool_ID { get; set; }

        public DateTime RentlDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan()
        { 
        }

        public Loan(int cust, int bookID, DateTime rented)
        {
            CustomerID = cust;
            Tool_ID = bookID;
            RentlDate = rented;


        }
    }
}
