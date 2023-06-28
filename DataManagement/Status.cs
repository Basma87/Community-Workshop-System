using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
  public  class Status
    {
        public int StatusID { get; set; }

        public string status { get; set; }

        public Status()
        { }
        public Status(string statusName)
        {
            status = statusName;
        }

    }
}
