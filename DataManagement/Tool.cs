using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
  public  class Tool
    {
        // old props keep them
        public int Tool_ID { get; set; }

        public string ProductNumber { get; set; }

        public string ProductName { get; set; }

        public string ProductBrand { get; set; }

        public string CurrentCondition { get; set; }

        public int StatusID { get; set; }

        public Tool()
        { 

        }

        public Tool( string number, string name,  string brand,string condition, int id)
        {
            
            ProductNumber = number;
            ProductName = name;
            CurrentCondition = condition;
            ProductBrand = brand;
            StatusID = id;
        }




      


    }
}
