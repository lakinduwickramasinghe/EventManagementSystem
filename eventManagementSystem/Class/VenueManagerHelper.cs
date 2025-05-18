using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eventManagementSystem
{
    public class VenueManagerHelper
    {
        private string connectionString;

        public VenueManagerHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public void deleteRequest(int RecordId)
        {
            string query = "DELETE FROM user_venuemanager_pending WHERE userVenue=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", RecordId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void addVenueManager(VenueManager manager,int venueId,int password)
        {
            string query = "INSERT INTO user_venuemanager (userEmail, firstName, lastName, mobileNumber, nicNumber, profileImage,userPassword, internalRole, userRole, userStatus, userVenue) VALUES (@userEmail, @firstName, @lastName, @mobileNumber, @nicNumber, @profileImage,@password, @internalRole,'Venue Manager', @userStatus, @userVenue)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@userEmail", manager.email);
                    cmd.Parameters.AddWithValue("@firstName", manager.firstName);
                    cmd.Parameters.AddWithValue("@lastName", manager.lastName);
                    cmd.Parameters.AddWithValue("@mobileNumber", manager.mobileNumber);
                    cmd.Parameters.AddWithValue("@nicNumber", manager.nicNumber);
                    cmd.Parameters.AddWithValue("@profileImage", manager.profileImage);
                    cmd.Parameters.AddWithValue("@internalRole", manager.internalRole);

                    cmd.Parameters.AddWithValue("@userStatus", "Password Reset");
                    cmd.Parameters.AddWithValue("@userVenue", venueId);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void addVenueManagerRequest(VenueManager manager)
        {
            string query = "INSERT INTO user_venuemanager_pending (userEmail, firstName, lastName, mobileNumber, nicNumber, profileImage, internalRole, userRole, userStatus, userVenue) VALUES (@userEmail, @firstName, @lastName, @mobileNumber, @nicNumber, @profileImage, @internalRole, @userRole, @userStatus, @userVenue)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@userEmail", manager.email);
                    cmd.Parameters.AddWithValue("@firstName", manager.firstName);
                    cmd.Parameters.AddWithValue("@lastName", manager.lastName);
                    cmd.Parameters.AddWithValue("@mobileNumber", manager.mobileNumber);
                    cmd.Parameters.AddWithValue("@nicNumber", manager.nicNumber);
                    cmd.Parameters.AddWithValue("@profileImage", manager.profileImage);
                    cmd.Parameters.AddWithValue("@internalRole", manager.internalRole);
                    cmd.Parameters.AddWithValue("@userRole", manager.userRole);
                    cmd.Parameters.AddWithValue("@userStatus", manager.userStatus);
                    cmd.Parameters.AddWithValue("@userVenue", manager.userVenueId);

                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public VenueManager GetVenueManagerById(int venueId)
        {
            VenueManager manager = null;
            string query = "SELECT userEmail, firstName, lastName, mobileNumber, nicNumber, profileImage, internalRole, userRole, userStatus, userVenue " +
                           "FROM user_venuemanager_pending WHERE userVenue = @venue"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@venue", venueId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userEmail = reader["userEmail"].ToString();
                            string firstName = reader["firstName"].ToString();
                            string lastName = reader["lastName"].ToString();
                            string mobileNumber = reader["mobileNumber"].ToString();
                            string nicNumber = reader["nicNumber"].ToString();
                            string profileImage = reader["profileImage"].ToString();
                            string internalRole = reader["internalRole"].ToString();
                            string userRole = reader["userRole"].ToString();
                            string userStatus = reader["userStatus"].ToString();
                            int userVenue = Convert.ToInt32(reader["userVenue"]);

                            manager = new VenueManager(userEmail, firstName,lastName,mobileNumber,nicNumber,profileImage,"0",internalRole,userRole,"",userVenue);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return manager;
        }


    }
}
