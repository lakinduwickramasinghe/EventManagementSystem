using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eventManagementSystem.admin
{
    public class PaymentHelper
    {
        private string connectionString;

        public PaymentHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public int addPayment(Payment pm)
        {
            int paymentId = 0;
            string query = "INSERT INTO payment_transaction (ccType,ccNumber,ccCvn,transactionAmount) VALUES(@type,@number,@cvn,@amount)";
            string query2 = "Select paymentId FROM payment_transaction where ccNumber=@cardnum AND ccCvn=@cnv";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", pm.cardType);
                    cmd.Parameters.AddWithValue("@number", pm.cardNumber);
                    cmd.Parameters.AddWithValue("@cvn", pm.cvn);
                    cmd.Parameters.AddWithValue("@amount", pm.amount);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@cardnum", pm.cardNumber);
                    cmd2.Parameters.AddWithValue("@cnv", pm.cvn);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        paymentId = (int)reader["paymentId"];
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return paymentId;
        }
    }
}
