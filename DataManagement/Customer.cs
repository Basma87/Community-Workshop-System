using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
   public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName{ get; set; }
        public  string Phone { get; set; }

        public string FullName   ///to get full name of user and load it in the combo box of add new tool rental
        { 
            get {return $"{LastName},{FirstName}"; } 
        }
    }
}
