using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.DAL
{
   public class CategorySetupRepository
    {
        private static string conString = "Server= DESKTOP-B86R21Q; Database= StockManagementSystem; Integrated Security=true";
        SqlConnection con = new SqlConnection(conString);
       public bool IsSave(Category category)
       {

           string query = "INSERT INTO Categories VALUES ('" + category.CategoryName + "', '" + category.UserName + "', '" +
                          category.CreateDate + "')";
           SqlCommand command = new SqlCommand(query, con);
           con.Open();
           int isRowAffected = command.ExecuteNonQuery();
           con.Close();
           if (isRowAffected > 0)
           {
               
               return true;
           }

           
           return false;
       }

        //public bool ShowValue(Category category)
        //{
        //    string query = "SELECT * FROM Categories";
        //    SqlCommand command = new SqlCommand(query, con);
        //    con.Open();
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //    DataTable dataTable=new DataTable();
        //    dataAdapter.Fill(dataTable);
        //}

        public bool IsExist(Category category)
        {
            string query = "SELECT * FROM Categories WHERE Name= ('" + category.CategoryName +"')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            
            
            if (dataReader.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public DataTable ShowCategories()
        {
            string query = "SELECT * FROM Categories";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool UpdateCategories(Category category)
        {
            string query = "UPDATE Categories SET Name='" + category.CategoryName + "' WHERE Id='" + category.Id + "' ";

            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
    }
}
