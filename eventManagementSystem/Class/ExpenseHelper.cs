using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eventManagementSystem.admin
{
    public class ExpenseHelper
    {
        private string connectionString;

        public ExpenseHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public void addExpense(Expense ex)
        {
            string query = "INSERT INTO event_expense (eventId,expenseAmount,expenseCategory,expenseRemarks) VALUES(@eventId,@expenseAmount,@expenseCategory,@expenseRemarks)";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eventId",ex.eventId);
                    cmd.Parameters.AddWithValue("@expenseAmount",ex.expenseAmount);
                    cmd.Parameters.AddWithValue("@expenseCategory",ex.expenseCategory);
                    cmd.Parameters.AddWithValue("@expenseRemarks",ex.expenseRemarks);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception exm)
                {
                    MessageBox.Show(exm.Message);
                }
            }
        }

        public void addCategory(string name)
        {
            string query = "INSERT INTO expense_categories (categoryName) VALUES(@name)";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.ExecuteNonQuery ();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void deleteExpenseCategory(string id)
        {
            string query = "SELECT expenseId FROM event_expense where expenseCategory=@cat";
            string query2 = "DELETE FROM expense_categories where categoryId=@id";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@cat",id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        SqlCommand cmd2 = new SqlCommand (query2,conn);
                        cmd2.Parameters.AddWithValue("@id",id);
                        cmd2.ExecuteNonQuery ();
                        MessageBox.Show("Category Delected Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete this category since there are expense records that is assigned to this category! ");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
