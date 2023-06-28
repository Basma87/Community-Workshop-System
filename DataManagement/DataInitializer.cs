using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataManagement
{
    /// <summary>
    /// PArt to build database through code if it deosn't exists
    /// </summary>
    public class DataInitializer : Adapter, IDataInitializer
    {
        public void BuildDatabase()
        {
            CreateDatabase();

            if (DoTablesExist() == false)
            {
                CreateTables();
                SeedDatabase();
            }
        }

        private void CreateTables()
        {
            createCustomerTable();
            createStatusTable();
            CreateToolsTable();
            CreateRentalstable();
           
        }

        private void createCustomerTable()
        {
            string tableName = "Customers";
            string structure = "CustomerID int IDENTITY (1,1) PRIMARY KEY, " +
                "LastName varchar(50) NOT NULL, " +
                "FirstName Varchar(50) NOT NULL, " +
                "Phone Varchar(20) NOT NULL";

            CreateNewTable(tableName, structure);
        }

        public void SeedDatabase()
        {
            seedCustomerTable();
            seedStatusTable();
            seedToolsTable();
            seedRentalTable();
            
        }

        private void seedCustomerTable()
        {
            List<Customer> newCustomers = new List<Customer>();
            newCustomers.Add(new Customer { LastName = "Gomaa", FirstName = "Basma", Phone = "458752585" });
            newCustomers.Add(new Customer { LastName = "Naguib", FirstName = "Ahmed", Phone = "12354558" });
            newCustomers.Add(new Customer { LastName = "Fouad", FirstName = "Azza", Phone = "5687991" });
            newCustomers.Add(new Customer { LastName = "Ragab", FirstName = "Amr", Phone = "6874566" });
            newCustomers.Add(new Customer { LastName = "Gomaa", FirstName = "Alaa", Phone = "01200335598" });
            newCustomers.Add(new Customer { LastName = "tawfik", FirstName = "Kawthar", Phone = "45878952" });

            foreach (var customer in newCustomers)
            {
                SaveSingleCustomer(customer);
            }
            //  newCustomers.Add(new Customer("last","first","phone")); => if you have customer constructor
        }


        private void seedToolsTable()
        {
            // 1--> active, 2--> on rental, 3--> retired

            List<Tool> newTools = new List<Tool>();

            newTools.Add(new Tool { ProductNumber = "2Xch22C", ProductName = "Hammer", ProductBrand = "Bosch", CurrentCondition = "Damaged", StatusID = 3 });
            newTools.Add(new Tool {ProductNumber= "2Xch22D",ProductName= "Hammer", ProductBrand="Hilti",CurrentCondition= "brand new",StatusID= 2 });
            newTools.Add(new Tool{ ProductNumber = "DER6987Y", ProductName="Circular Saw", ProductBrand = "Bosch", CurrentCondition = "good condition", StatusID = 2 });
            newTools.Add(new Tool{ ProductNumber = "Xd5677P", ProductName ="Utility Knife", ProductBrand = "Festool", CurrentCondition = "good condition", StatusID = 2 });
            newTools.Add(new Tool{ ProductNumber = "H87P45", ProductName= "Wood Chisel (1 inch)", ProductBrand = "Ridgid", CurrentCondition = "good condition", StatusID = 1 });
            newTools.Add(new Tool{ ProductNumber = "TY6622L", ProductName= "Circular Saw", ProductBrand = "Brand 1", CurrentCondition = "Damaged", StatusID = 3 });
            newTools.Add(new Tool{ ProductNumber = "552122", ProductName="wooden shelf", ProductBrand = "brand 3",CurrentCondition = "brand new", StatusID = 1 });
            newTools.Add(new Tool{ ProductNumber = "SHY584R", ProductName= "Tape Measure", ProductBrand = "Brand 1", CurrentCondition = "Brand New", StatusID = 1 });
            newTools.Add(new Tool{ ProductNumber = "H7Ul66", ProductName= "Wooden Shelf", ProductBrand = "Makita", CurrentCondition = "good condition", StatusID = 1 });
            newTools.Add(new Tool{ ProductNumber = "KL51TYU", ProductName="Speed Square", ProductBrand = "Milwaukee", CurrentCondition = "good condition", StatusID = 1 });




            foreach (var tool in newTools)
            {
                AddTool(tool);
            }
        }


        private void seedRentalTable()
        {
            List<RentedTools> newrentedTools = new List<RentedTools>();
            newrentedTools.Add(new RentedTools { CustomerID= 1,Tool_ID= 2,Rented_Date= System.DateTime.Now.AddDays(-2).AddHours(3) });
            newrentedTools.Add(new RentedTools { CustomerID=1,Tool_ID= 3,Rented_Date= System.DateTime.Now.AddDays(-2).AddHours(3) });
            newrentedTools.Add(new RentedTools { CustomerID = 3, Tool_ID = 4, Rented_Date = System.DateTime.Now.AddDays(-2).AddHours(3) });
            newrentedTools.Add(new RentedTools { CustomerID = 6, Tool_ID = 2, Rented_Date = System.DateTime.Now.AddDays(-2).AddHours(3) });
            newrentedTools.Add(new RentedTools {CustomerID= 5,Tool_ID= 3,Rented_Date= System.DateTime.Now.AddDays(-2).AddHours(3) });
            
            foreach (var rentedTool in newrentedTools)
            {
                AddnewRentedTool(rentedTool);
            }
        }

        private void seedStatusTable()
        {
            List<Status> statusList = new List<Status>();
            statusList.Add(new Status { status = "Active" });
            statusList.Add(new Status { status = "On Rental" });
            statusList.Add(new Status { status= "Retired" });

            foreach (var status in statusList)
            {
                AddNewStatus(status);
            }
            
        }
        #region Database Building
   
        public void CreateDatabase()
        {
            SqlConnection connection = Helper.CreateDatabaseConnection();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                string connectionString = $"Data Source={connection.DataSource}; " +
                    $"Integrated Security=True";

                string sql = $"IF NOT EXISTS (Select 1 from sys.databases where " +
                    $"name= '{connection.Database}') " +
                    $"CREATE DATABASE {connection.Database}";

                using (SqlConnection connServer=new SqlConnection(connectionString))
                {
                    using (sqlCommand=new SqlCommand(sql,connServer))
                    {
                        if (connServer.State== ConnectionState.Closed)
                        {
                            connServer.Open();
                        }
                        sqlCommand.ExecuteNonQuery();
                        connServer.Close();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

           
        }
        #endregion

        #region Checking Tables
        private bool DoTablesExist()
        {
            var connection = Helper.CreateDatabaseConnection();
            
            string sql = $"SELECT COUNT(*) from " +
                $"{connection.Database}.INFORMATION_SCHEMA.TABLES " +
                $"Where TABLE_TYPE = 'BASE Table'";

            using (connection)
            {
                int num = connection.QuerySingle<int>(sql);  // return number of existing tables

                if (num > 0)
                {
                    return true;
                }
                return false;
            }
        }

        private void CreateNewTable(string tableName,string structure)
        {
            string sql = $"CREATE Table {tableName} ({structure})";

            using (var connection=Helper.CreateDatabaseConnection())
            {
                try
                {
                    connection.Execute(sql);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
                }
            }
        }
        #endregion


        private void CreateToolsTable()
        {
            string tableName = "Tools";
            string structure = "Tool_ID int Identity (1,1) PRIMARY Key, " +
                "ProductNumber varchar(50) NOT NULL, " +
                "ProductName varchar(50) NOT NUll, " +
                "ProductBrand varchar(50) NOT NUll, " +
                "CurrentCondition varchar(225) , " +
                "StatusID int NOT NULL, " +
                "FOREIGN KEY(StatusID) REFERENCES Status(StatusID) ";
            CreateNewTable(tableName,structure);

        }

        private void CreateRentalstable()
        {
            string tableName = "Rented_Tools";
            string structure= "ID int IDENTITY(1,1) PRIMARY KEY, " +
                "Tool_ID int not NULL, " +
                "CustomerID int NOT NULL, " +
                "Rented_Date DATETIME NOT NULL, " +
                "Returned_Date DATETIME, " +
                "FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID), " +
                "FOREIGN KEY(Tool_ID) REFERENCES Tools(Tool_ID) ";
            CreateNewTable(tableName, structure);
        }

        private void createStatusTable()
        {
            string tableName = "Status";
            string stucture = "StatusID int IDENTITY(1,1) PRIMARY KEY, " +
                "status varchar(50) NOT NULL ";

            CreateNewTable(tableName, stucture);
        }
    }

    
    
}
