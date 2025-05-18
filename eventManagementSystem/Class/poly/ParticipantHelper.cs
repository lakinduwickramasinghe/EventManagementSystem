using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eventManagementSystem.admin
{
    public class ParticipantHelper
    {
        private string connectionString;

        public ParticipantHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public DataTable returnConfirmations(string email)
        {
            DataTable data = new DataTable();
            string query = "select * from event_confirmations where userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return data;
        }


        public DataTable returnTickets(string email)
        {
            DataTable data = new DataTable();
            string query = "select * from event_ticket_trasaction where userEmail=@email";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return data;
        }

        public void createTicketTransaction(int paymentId, int ticketcount, string email, int eventId)
        {
            string query = "insert into event_ticket_trasaction (paymentId,ticketCount,userEmail,eventId) values(@payment,@count,@email,@eventid)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@payment", paymentId);
                    cmd.Parameters.AddWithValue("@count", ticketcount);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@eventid", eventId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }


        public void createConfirmation(int personCount, string email, int eventId)
        {
            string query = "insert into event_confirmations (personCount,userEmail,eventId) values(@count,@email,@event)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@count", personCount);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@event", eventId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }


        public void updateparticipationDetails(int eventId, int ticketCount)
        {
            string query = "update event_participation_details set availableBalance=availableBalance-@count where eventId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@count", ticketCount);
                    cmd.Parameters.AddWithValue("@id", eventId);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        public void updateTicketBalance(int eventId,int ticketCount)
        {
            string query = "update event_ticket_details set availableBalance=availableBalance-@count where eventId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand (query, conn);
                    cmd.Parameters.AddWithValue("@count", ticketCount);
                    cmd.Parameters.AddWithValue("@id", eventId);

                    cmd.ExecuteNonQuery ();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        public void addParticipant(Participant p1)
        {
            string query = "insert into user_participant (userEmail,firstName,lastName,mobileNumber,userPassword,userRole,userStatus) Values(@userEmail,@firstName,@lastName,@mobileNumber,@userPassword,@userRole,@userStatus)";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userEmail",p1.email);
                    cmd.Parameters.AddWithValue("@firstName",p1.firstName);
                    cmd.Parameters.AddWithValue("@lastName",p1.lastName);
                    cmd.Parameters.AddWithValue("@mobileNumber",p1.mobileNumer);
                    cmd.Parameters.AddWithValue("@userPassword",p1.password);
                    cmd.Parameters.AddWithValue("@userRole",p1.userRole);
                    cmd.Parameters.AddWithValue("@userStatus",p1.userStatus);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public bool participantLoginValidate(string email,string password)
        {
            bool isSuccessfull = false;
            bool isEmailCorrent = false;
            string pw=null;
            string query = "SELECT userPassword from user_participant where userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
  
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@email",email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        pw = reader["userPassword"].ToString();
                        isEmailCorrent=true;
                        if (isEmailCorrent == true)
                        {
                            if (password == pw)
                            {
                                isSuccessfull = true;
                            }
                            else
                            {
                                isSuccessfull=false;
                                MessageBox.Show("Invalid email or password","login failed",MessageBoxButton.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "login failed", MessageBoxButton.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }


            return isSuccessfull;
        }
    }
}
