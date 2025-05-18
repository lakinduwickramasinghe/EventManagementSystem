using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eventManagementSystem
{
    public class VenueHelper
    {
        private string connectionString;

        public VenueHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }


        public void venueImageRequest(DataTable table)
        {
            string query = "INSERT INTO venue_images_pending(venueId,imageData) VALUES(@venue,@image);";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    foreach (DataRow row in table.Rows)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@venue", row["VenueId"]);
                        cmd.Parameters.AddWithValue("@image", row["ImageData"]);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public DataTable getVenueImages(int venueId)
        {
            DataTable table = new DataTable();
            string query = "select * from venue_images where venueId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                    conn.Open ();   
                    SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",venueId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    conn.Close();
                
            }
            return table;
        }


        public DataTable returnVenues()
        {
            string query = "SELECT * from venue";
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
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

        public void removevenueImageRequest(int venueId)
        {
            string query = "DELETE FROM venue_images_pending where venueId=@id;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", venueId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public DataTable GetVenueImagesByVenueId(int venueId)
        {
            string query = "SELECT * FROM venue_images_pending WHERE venueId = @venueId;";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@venueId", venueId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dataTable;
        }


        public void addvenueImage(DataTable table, int VenueId)
        {
            string query = "INSERT INTO venue_images(venueId,imageData) VALUES(@venue,@image);";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    foreach (DataRow row in table.Rows)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@venue", VenueId);
                        cmd.Parameters.AddWithValue("@image", row["ImageData"]);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public int addVenue(Venue venue)
        {
            int venueId = 0;
            string query = "INSERT INTO venue(venueName,venueDisplayName,venueDescription,venueAddress,venueEmail,venueContactNumber,compName,compAddress,compContactNumber,compBRN,compTIN) VALUES(@name,@displayName,@description,@address,@email,@number,@compName,@compAddress,@compContactNumber,@brn,@tin)";
            string query2 = "SELECT venueId FROM venue where venueName=@name and venueDisplayName=@displayName and venueEmail=@email and compBRN=@brn";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", venue.venueName);
                    cmd.Parameters.AddWithValue("@displayName", venue.venueDisplayName);
                    cmd.Parameters.AddWithValue("@description", venue.venueDescription);
                    cmd.Parameters.AddWithValue("@address", venue.venueAddress);
                    cmd.Parameters.AddWithValue("@email", venue.venueEmail);
                    cmd.Parameters.AddWithValue("@number", venue.venueContactNumber);

                    cmd.Parameters.AddWithValue("@compName", venue.companyName);
                    cmd.Parameters.AddWithValue("@compAddress", venue.companyAddress);
                    cmd.Parameters.AddWithValue("@compContactNumber", venue.companyContactNumber);
                    cmd.Parameters.AddWithValue("@brn", venue.companyBRN);
                    cmd.Parameters.AddWithValue("@tin", venue.companyTIN);

                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@name", venue.venueName);
                    cmd2.Parameters.AddWithValue("@displayName", venue.venueDisplayName);
                    cmd2.Parameters.AddWithValue("@email", venue.venueEmail);
                    cmd2.Parameters.AddWithValue("@brn", venue.companyBRN);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            venueId = (int)reader["venueId"];
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return venueId;
        }

        public void deleteRequest(int RecordId)
        {
            string query = "DELETE FROM venue_pending where venueId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id",RecordId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int addVenueRequest(Venue venue)
        {
            int venueId = 0;
            string query = "INSERT INTO venue_pending (venueName,venueDisplayName,venueDescription,venueAddress,venueEmail,venueContactNumber,compName,compAddress,compContactNumber,compBRN,compTIN) VALUES(@name,@displayName,@description,@address,@email,@number,@compName,@compAddress,@compContactNumber,@brn,@tin)";
            string query2 = "SELECT venueId FROM venue_pending where venueName=@name and venueDisplayName=@displayName and venueEmail=@email and compBRN=@brn";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@name",venue.venueName);
                    cmd.Parameters.AddWithValue("@displayName",venue.venueDisplayName);
                    cmd.Parameters.AddWithValue("@description",venue.venueDescription);
                    cmd.Parameters.AddWithValue("@address",venue.venueAddress);
                    cmd.Parameters.AddWithValue("@email",venue.venueEmail);
                    cmd.Parameters.AddWithValue("@number",venue.venueContactNumber);

                    cmd.Parameters.AddWithValue("@compName", venue.companyName);
                    cmd.Parameters.AddWithValue("@compAddress", venue.companyAddress);
                    cmd.Parameters.AddWithValue("@compContactNumber", venue.companyContactNumber);
                    cmd.Parameters.AddWithValue("@brn", venue.companyBRN);
                    cmd.Parameters.AddWithValue("@tin", venue.companyTIN);

                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@name", venue.venueName);
                    cmd2.Parameters.AddWithValue("@displayName", venue.venueDisplayName);
                    cmd2.Parameters.AddWithValue("@email", venue.venueEmail);
                    cmd2.Parameters.AddWithValue("@brn", venue.companyBRN);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            venueId = (int)reader["venueId"];
                            MessageBox.Show("Venue Id Saved!");
                        }
                    }
                        
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return venueId;
        }

        public Venue returnVenue(int venueId)
        {
            Venue venue = null;
            string query = "SELECT venueName, venueDisplayName, venueDescription, venueAddress, venueEmail, venueContactNumber, compName, compAddress, compContactNumber, compBRN, compTIN FROM venue WHERE venueId = @venueId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@venueId", venueId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string venueName = reader["venueName"].ToString();
                            string venueDisplayName = reader["venueDisplayName"].ToString();
                            string venueDescription = reader["venueDescription"].ToString();
                            string venueAddress = reader["venueAddress"].ToString();
                            string venueEmail = reader["venueEmail"].ToString();
                            string venueContactNumber = reader["venueContactNumber"].ToString();

                            string companyName = reader["compName"].ToString();
                            string companyAddress = reader["compAddress"].ToString();
                            string companyContactNumber = reader["compContactNumber"].ToString();
                            string companyBRN = reader["compBRN"].ToString();
                            string companyTIN = reader["compTIN"].ToString();

                            venue = new Venue(venueName, venueDisplayName, venueDescription, venueAddress, venueEmail, venueContactNumber, companyName, companyAddress, companyContactNumber, companyBRN, companyTIN);
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return venue;
        }


        public Venue getVenueById(int venueId)
        {
            Venue venue = null;
            string query = "SELECT venueName, venueDisplayName, venueDescription, venueAddress, venueEmail, venueContactNumber, venueImages, compName, compAddress, compContactNumber, compBRN, compTIN FROM venue_pending WHERE venueId = @venueId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@venueId", venueId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string venueName = reader["venueName"].ToString();
                            string venueDisplayName = reader["venueDisplayName"].ToString();
                            string venueDescription = reader["venueDescription"].ToString();
                            string venueAddress = reader["venueAddress"].ToString();
                            string venueEmail = reader["venueEmail"].ToString();
                            string venueContactNumber = reader["venueContactNumber"].ToString();
                           

                            string companyName = reader["compName"].ToString();
                            string companyAddress = reader["compAddress"].ToString();
                            string companyContactNumber = reader["compContactNumber"].ToString();
                            string companyBRN = reader["compBRN"].ToString();
                            string companyTIN = reader["compTIN"].ToString();

                            venue = new Venue(venueName,venueDisplayName,venueDescription,venueAddress,venueEmail,venueContactNumber,companyName,companyAddress,companyContactNumber,companyBRN,companyTIN);
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return venue;
        }



    }
}
