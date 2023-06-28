using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataManagement
{
    public static class Helper
    {
        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static SqlConnection CreateDatabaseConnection()
        {
            return new SqlConnection(GetConnectionString("Community Workshop"));
        }


        public static IDataAdapter GetAdapter()
        {
            //return new TestAdapter(); // for testing
            return new Adapter();
        }
    }

   
}
