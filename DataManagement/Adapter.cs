using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

/// <summary>
/// this Class is used to perform dataBase Operations adding, deleting, inserting, and updating tables.
/// </summary>
namespace DataManagement
{
    
    public class Adapter : IDataAdapter
    {
       
        #region Customer Methods

        /// <summary>
        /// retrieve all customers from the database
        /// </summary>
        /// <returns> list with all customers</returns>
        public List<Customer> GetAllCustomers()
        {
            try
            {
                string sql = "SELECT * from Customers";

                using (var connetion = Helper.CreateDatabaseConnection())
                {
                    return connetion.Query<Customer>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get a single customer based on id 
        /// </summary>
        /// <param name="id"> customer id</param>
        /// <returns>customer object</returns>
        public Customer getSingleCustomerDetails(int id)
        {
            string sql = $"SELECT * from Customers where CustomerID={id}";

            using (var connection = Helper.CreateDatabaseConnection())

            {
                return connection.QuerySingle<Customer>(sql);
            }
        }
        /// <summary>
        /// update customer data and save it to adatabase
        /// </summary>
        /// <param name="newCustomer"> customer object</param>
        public void saveExistinCustomer(Customer newCustomer)
        {
            string sql = "UPDATE Customers SET " +
                "LastName=@LastName,FirstName=@FirstName,Phone=@Phone " +
                $"WHERE CustomerID={newCustomer.CustomerID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newCustomer);
            }
        }
        /// <summary>
        /// add new customer in the database
        /// </summary>
        /// <param name="newCustomer">customer object</param>
        public void SaveSingleCustomer(Customer newCustomer)
        {
            string sql = "INSERT INTO Customers " +
                "(LastName,FirstName,Phone) " +
                "VALUES (@LastName,@FirstName,@Phone)";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newCustomer);
            }
        }
        /// <summary>
        /// delete customer from the database using id
        /// </summary>
        /// <param name="id">customer id </param>
        public void DeleteCustomer(int id)
        {
            string sql = $"DELETE from Customers where CustomerID={id}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }

        }

        #endregion


        #region Tools Methods

        /// <summary>
        /// retrieve all tool in the database
        /// </summary>
        /// <returns>tools list</returns>
        public List<Tool> GetToolsList()
        {
            try
            {
                string sql = "SELECT * from Tools";

                using (var connetion = Helper.CreateDatabaseConnection())
                {
                    return connetion.Query<Tool>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// retrieve specific tool by its id  
        /// </summary>
        /// <param name="id">tool id </param>
        /// <returns></returns>
        public ToolsView GetToolbyID(int id)
        {
            string sql = "SELECT Status.status, Tools.* " +
                "FROM Status " +
                "INNER JOIN " +
                "Tools ON Status.StatusID = Tools.StatusID " +
                $"WHERE tools.Tool_ID ={id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<ToolsView>(sql);
            }
        }
        /// <summary>
        /// retrieves all tools from database based on a status
        /// </summary>
        /// <param name="statusID"> tools status</param>
        /// <returns></returns>
        public List<Tool> GetToolsList(int statusID)
        {
            try
            {
                string sql = $"SELECT * from Tools where StatusID={statusID}";

                using (var connetion = Helper.CreateDatabaseConnection())
                {
                    return connetion.Query<Tool>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// retrieve all tools from tools table joining with table status to get tool status as well 
        /// </summary>
        /// <returns> list of tools and their status</returns>
            public List<ToolsView> GetAllTools()   
        {

            try
            {
                string sql = "select Tools.Tool_ID,Tools.ProductNumber, Tools.ProductName, " +
                    "Tools.ProductBrand, Tools.CurrentCondition, Status.Status " +
                    "from tools inner join Status on Tools.StatusID = Status.StatusID "; 

                using (var connetion = Helper.CreateDatabaseConnection())
                {
                    return connetion.Query<ToolsView>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }

        /// <summary>
        /// retrieve all tools with a certain status using statusID
        /// </summary>
        /// <param name="id">status ID</param>
        /// <returns>tool list</returns>
        public List<ToolsView> GetAllTools(int id)    
        {

            try
            {
                string sql = "select Tools.Tool_ID,Tools.ProductNumber," +
                    " Tools.ProductName, " +
                    "Tools.ProductBrand, " +
                    "Tools.CurrentCondition, " +
                    "Status.Status " +
                    "from tools " +
                    "inner join Status " +
                    "on Tools.StatusID = Status.StatusID " +
                    $"WHERE Status.StatusID={id} "; 

                using (var connetion = Helper.CreateDatabaseConnection())
                {
                    return connetion.Query<ToolsView>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }

        /// <summary>
        /// update tool details 
        /// </summary>
        /// <param name="tool">tool object</param>
        public void updateTool(Tool tool)
        {
            string sql = "UPDATE tools SET " +
                $"ProductNumber=@ProductNumber, " +
                $"ProductName=@ProductName,ProductBrand=@ProductBrand, " +
                $"CurrentCondition=@CurrentCondition,StatusID=@StatusID " +
                $"WHERE tools.Tool_ID={tool.Tool_ID}";

            using (var connection=Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql,tool);
            }
        }

        /// <summary>
        /// updates tool status in the database
        /// </summary>
        /// <param name="id"> tool id</param>
        /// <param name="newStatus"> status value passed from a method</param>
        public void updateToolRentalStatus(int id, int newStatus)
        {
                string sql = "UPDATE Tools SET " +
                $"StatusID ={newStatus} " +
                $"where Tool_ID={id}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }

        /// <summary>
        /// method to update tool condition
        /// </summary>
        /// <param name="id">tool id</param>
        /// <param name="newStatus"> status passed from a method</param>
        /// <param name="condition">condition passed from a method</param>
        public void updateToolRentalStatus(int id, int newStatus,string condition)
        {
            string sql = "UPDATE Tools SET " +
            $"StatusID ={newStatus}, " +
            $"CurrentCondition ='{condition}' " +
            $"where Tool_ID={id}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }
        /// <summary>
        /// delete specific tool from the database
        /// </summary>
        /// <param name="id"> tool id</param>
        public void DeleteTool(int id)
        {
            string sql = $"DELETE from Tools where Tool_ID={id}";
            using (var connection=Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }

        /// <summary>
        /// insert new tool in the database
        /// </summary>
        /// <param name="tool">tool object</param>
        public void AddTool(Tool tool)
        {
            

            string sql = "INSERT into Tools " +
                "(ProductNumber,ProductName,ProductBrand,CurrentCondition,StatusID) " +
                "VALUES(@ProductNumber,@ProductName,@ProductBrand,@CurrentCondition,@StatusID)";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, tool);
            }
        }

            #endregion

            #region Status

        /// <summary>
        /// get all status from database
        /// </summary>
        /// <returns>status list</returns>
            public List<Status> getAllStatus()
        {
            try
            {
                string sql = "SELECT * from Status";
                using (var connection = Helper.CreateDatabaseConnection())
                {
                    return connection.Query<Status>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void AddNewStatus(Status status)
        {
            try
            {
                string sql = "INSERT INTO Status " +
                    "(status) " +
                    "Values (@status)";

                using (var connection = Helper.CreateDatabaseConnection())
                {
                    connection.Execute(sql,status);
                }
            }
            catch (Exception e)
            { 
            }
        }
        #endregion

        #region Rented Tools
     
        /// <summary>
        /// add new tool rental
        /// </summary>
        /// <param name="rentedtool">rented tool object</param>
        public void AddnewRentedTool(RentedTools rentedtool)
        {
            string sql = "INSERT into Rented_tools" +
                "(CustomerID,Tool_ID,Rented_Date)" +
                "Values(@CustomerID,@Tool_ID,@Rented_Date)";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, rentedtool);
            }
        }

     /// <summary>
     /// get all rented tools
     /// </summary>
     /// <returns>list of rented tools</returns>

        public List<RentedToolsView> GetAllRentedTools()
        {
         

            string sql = "SELECT Rented_tools.ID, Rented_tools.Rented_Date, Rented_tools.Returned_Date, " +
                " Tools.ProductName, " +
                " Customers.LastName, Customers.FirstName " +
                " FROM Customers " +
                " INNER JOIN " +
                " Rented_tools ON Customers.CustomerID = Rented_tools.CustomerID " +
                " INNER JOIN " +
                " Tools ON Rented_tools.Tool_ID = Tools.Tool_ID ";

            using (var connection=Helper.CreateDatabaseConnection())
                {
                   return connection.Query < RentedToolsView > (sql).ToList();
                }
        }
        /// <summary>
        /// get all rented tools by a certain customer
        /// </summary>
        /// <param name="id"> customer id</param>
        /// <returns>list of rented tools</returns>
        public List<RentedToolsView> GetAllRentedToolsByCustomerID(int id)
        {
            string sql = "SELECT Rented_tools.ID, Rented_tools.Rented_Date, Rented_tools.Returned_Date, " +
                " Tools.ProductName, " +
                " Customers.LastName, Customers.FirstName " +
                " FROM Customers " +
                " INNER JOIN " +
                " Rented_tools ON Customers.CustomerID = Rented_tools.CustomerID " +
                " INNER JOIN " +
                " Tools ON Rented_tools.Tool_ID = Tools.Tool_ID " +
                $"WHERE (Rented_tools.Returned_Date is NULL AND Rented_tools.CustomerID={id}) ";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<RentedToolsView>(sql).ToList();
            }
        }

        /// <summary>
        /// get all data of rented tools based on rent ID
        /// </summary>
        /// <param name="id">rent ID</param>
        /// <returns>list of rented tools</returns>
        public RentedTools GetrentedToolbyID(int id)
        {
            string sql = $"SELECT * From Rented_tools where ID={id}";
            using (var connection=Helper.CreateDatabaseConnection())

            {
                return connection.QuerySingle<RentedTools>(sql);
            }
        }

        /// <summary>
        /// update rented tools detils 
        /// </summary>
        /// <param name="rentedTools">rented tool object</param>
        public void updateRentedToolstable( RentedTools rentedTools)
        {
            string sql = "UPDATE Rented_tools SET " +
                $"CustomerID=@CustomerID,Tool_ID=@Tool_ID,Rented_Date=@Rented_Date,Returned_Date=@Returned_Date " +
                $"WHERE ID={rentedTools.ID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, rentedTools);
            }
        }

        /// <summary>
        /// update rented tool return date.
        /// </summary>
        /// <param name="id">rent id</param>
        /// <param name="returnDate">date passed from a method</param>
        public void updateRentedToolstable(int id, DateTime returnDate)
        {
            string sql = "UPDATE Rented_tools SET " +
               $"CustomerID=@CustomerID,Tool_ID=@Tool_ID,RentlDate=@RentlDate,ReturnDate={returnDate} " +
                $"WHERE ID={id}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }

    }

    #endregion

}
