using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;

namespace eventManagementSystem
{
    public class EventSpaceHelper
    {
        private string connectionString;

        public EventSpaceHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public void addEventSpaceRequest(EventSpace space)
        {
            string query = "INSERT INTO venue_eventSpaces_pending(venueId,eventSpceName,eventSpaceCapacity,eventSpacePriceModel,eventSpacePriceRate,eventSpaceDiscription) VALUES(@venueId,@eventSpaceName,@eventSpaceCapacity,@eventSpacePriceModel,@eventSpacePriceRate, @eventSpaceDescription)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@venueId",space.venueId);
                    cmd.Parameters.AddWithValue("@eventSpaceName",space.eventSpaceName);
                    cmd.Parameters.AddWithValue("@eventSpaceCapacity",space.eventSpaceCapacity);
                    cmd.Parameters.AddWithValue("@eventSpacePriceModel",space.eventSpacePriceModel);
                    cmd.Parameters.AddWithValue("@eventSpacePriceRate", space.priceRate);
                    cmd.Parameters.AddWithValue("@eventSpaceDescription",space.eventSpaceDescription);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public DataTable returnVS(int venueId)
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM venue_eventSpaces where venueId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", venueId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return table;
        }



        public void deleteRequest(int RecordId)
        {
            string query = "DELETE FROM venue_eventSpaces_pending WHERE venueId=@id";
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

        public DataTable returnVenueSpaces(int VenueId)
        {
            DataTable datatable = new DataTable(); 
            string query = $"SELECT * FROM venue_eventSpaces_pending WHERE venueId = {VenueId}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(datatable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return datatable;
        }


        public void addEventSpaces(DataTable table, int VenueId)
        {
            string query = "INSERT INTO venue_eventSpaces (venueId, eventSpceName, eventSpaceCapacity, eventSpacePriceModel, eventSpacePriceRate, eventSpaceDiscription) " +
                           "VALUES (@venueId, @eventSpaceName, @capacity, @priceMode, @priceRate, @discription)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataRow row in table.Rows)
                {
                    if (row != null)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@venueId", VenueId);
                        cmd.Parameters.AddWithValue("@eventSpaceName", row["eventSpceName"]);
                        cmd.Parameters.AddWithValue("@capacity", row["eventSpaceCapacity"]);
                        cmd.Parameters.AddWithValue("@priceMode", row["eventSpacePriceModel"]);
                        cmd.Parameters.AddWithValue("@priceRate", row["eventSpacePriceRate"]);
                        cmd.Parameters.AddWithValue("@discription", row["eventSpaceDiscription"]);

                       
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


    }
}
