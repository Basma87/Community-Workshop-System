using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
   public class RentedToolsView
    {
        public int ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String ProductName { get; set; }
        public DateTime Rented_Date { get; set; }
        public DateTime? Returned_Date { get; set; }
    }
}
