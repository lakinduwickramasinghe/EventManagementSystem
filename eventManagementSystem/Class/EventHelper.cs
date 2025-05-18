using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System.Data;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.IO.Packaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;


namespace eventManagementSystem.Class
{
    public class EventHelper
    {
        private string connectionString;

        public EventHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }


        public DataTable returnPublicEvents()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM event where eIsPublic = 1 AND eIsActive = 1";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return table;
        }

        public DataTable returnFilterEvents(string type)
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM event where eIsPublic = 1 AND eIsActive = 1 and eType=@type";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", type);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return table;
        }

        public DataTable loadEventDatagrid()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM event";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;


        }

        public void deleteEvent(string recordId)
        {
            string query = "DELETE FROM event WHERE eId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",recordId);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Successfully deleted!", "Event Delete Message");

                }
                catch(SqlException ex)
                {
                    if(ex.Number == 547)
                    {
                        MessageBox.Show("Cannot delete the record because it is referenced by another record");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                conn.Close();

            }

        }

        public int addEvent(Event ev)
        {
            int eventId = 0;
            string query = "INSERT INTO event(eName,eDisplayName,eType,eDate,eStartTime,eEndTime,eIsPublic,eNeedTicketing,eNeedParticipationConfirmation,eNeedLocation,eCapacity,eMaxCapacity,eTicketCount,eTicketPrice,eBudget,eMaxBudget,eIsActive,eBannerImage,eCreatedBy,eCreatorRole) VALUES(@name,@displayName,@type,@date,@startTime,@endTime,@isPublic,@needTicketing,@needParticipation,@needLocation,@capacity,@maxCapacity,@ticketCount,@ticketValue,@budget,@maxBudget,@isActive,@imagedata,@creator,@creatorRole)";
            string query2 = "SELECT eId FROM event WHERE eName=@eName AND eDisplayName =@disName";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", ev.eventName);
                    cmd.Parameters.AddWithValue("@displayName", ev.displayName);
                    cmd.Parameters.AddWithValue("@type", ev.eventType);
                    cmd.Parameters.AddWithValue("@date", ev.eventDate);
                    cmd.Parameters.AddWithValue("@startTime", ev.startTime);
                    cmd.Parameters.AddWithValue("@endTime", ev.endTime);
                    cmd.Parameters.AddWithValue("@isPublic", ev.ispublic);
                    cmd.Parameters.AddWithValue("@needTicketing", ev.needTicketing);
                    cmd.Parameters.AddWithValue("@needParticipation", ev.needConfirmation);
                    cmd.Parameters.AddWithValue("@needLocation", ev.needLocation);
                    cmd.Parameters.AddWithValue("@capacity", ev.participantCount);
                    cmd.Parameters.AddWithValue("@maxCapacity", ev.maxParticipantCount);
                    cmd.Parameters.AddWithValue("@ticketCount", ev.ticketCount);
                    cmd.Parameters.AddWithValue("@ticketValue", ev.ticketValue);
                    cmd.Parameters.AddWithValue("@budget", ev.eventBudget);
                    cmd.Parameters.AddWithValue("@maxBudget", ev.maxBudget);
                    cmd.Parameters.AddWithValue("@isActive", ev.isActive);
                    cmd.Parameters.AddWithValue("@imagedata", ev.imageData.ToArray());
                    cmd.Parameters.AddWithValue("@creator", ev.userId);
                    cmd.Parameters.AddWithValue("@creatorRole", ev.userRole);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Event {ev.displayName} Saved Successfully!");
                    try
                    {
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@eName", ev.eventName);
                        cmd2.Parameters.AddWithValue("@disName", ev.displayName);
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                eventId = (int)reader["eId"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }


                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorrrrrrrr: "+ex.Message);
                }
            }
            return eventId;
        }

        public Event returnEvent(string eventId)
        {
            Event returnEvent = null;
            string query = "SELECT * FROM event WHERE eId=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", eventId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            string eventName = reader["eName"].ToString();
                            string displayName = reader["eDisplayName"].ToString();
                            string eventType = reader["eType"].ToString();
                            DateTime eventDate = Convert.ToDateTime(reader["eDate"]);
                            TimeSpan startTime = (TimeSpan)reader["eStartTime"];
                            TimeSpan endTime = (TimeSpan)reader["eEndTime"];
                            bool isPublic = Convert.ToBoolean(reader["eIsPublic"]);
                            bool needTicketing = Convert.ToBoolean(reader["eNeedTicketing"]);
                            bool needConfirmation = Convert.ToBoolean(reader["eNeedParticipationConfirmation"]);
                            bool needLocation = Convert.ToBoolean(reader["eNeedLocation"]);
                            int participantCount = Convert.ToInt32(reader["eCapacity"]);
                            int maxParticipantCount = Convert.ToInt32(reader["eMaxCapacity"]);
                            int ticketCount = Convert.ToInt32(reader["eTicketCount"]);
                            int ticketValue = Convert.ToInt32(reader["eTicketPrice"]);
                            bool isActive = Convert.ToBoolean(reader["eIsActive"]);
                            int eventBudget = Convert.ToInt32(reader["eBudget"]);
                            int maxBudget = Convert.ToInt32(reader["eMaxBudget"]);
                            byte[] imagedata = (byte[])reader["eBannerImage"];
                            int userId = (int)reader["eCreatedBy"];
                            string userRole = reader["eCreatorRole"].ToString();



                            returnEvent = new Event(
                                eventName,
                                displayName,
                                eventType,
                                eventDate,
                                eventDate.Add(startTime), 
                                eventDate.Add(endTime),   
                                isPublic,
                                needTicketing,
                                needConfirmation,
                                needLocation,
                                participantCount,
                                maxParticipantCount,
                                ticketCount,
                                ticketValue,
                                isActive,
                                eventBudget,
                                maxBudget,
                                imagedata,
                                userId,
                                userRole
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error [Location: EventHelper.cs returnEvent()]" + ex);
                }
            }

            return returnEvent;
        }

        public void UpdateEvent(Event ev,string eventId)
        {

            string query = "UPDATE event SET eName = @eName, eDisplayName = @eDisplayName, eType = @eType, eDate = @eDate, eStartTime = @eStartTime, eEndTime = @eEndTime, eIsPublic = @eIsPublic, eNeedTicketing = @eNeedTicketing, eNeedParticipationConfirmation = @eNeedParticipationConfirmation, eNeedLocation = @eNeedLocation, eCapacity = @eCapacity, eMaxCapacity = @eMaxCapacity, eTicketCount = @eTicketCount, eTicketPrice = @eTicketPrice, eBudget = @eBudget, eMaxBudget = @eMaxBudget, eIsActive = @eIsActive WHERE eId = @eId";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eId",eventId);
                    cmd.Parameters.AddWithValue("@eName", ev.eventName);
                    cmd.Parameters.AddWithValue("@eDisplayName", ev.displayName);
                    cmd.Parameters.AddWithValue("@eType", ev.eventType);
                    cmd.Parameters.AddWithValue("@eDate", ev.eventDate);
                    cmd.Parameters.AddWithValue("@eStartTime", ev.startTime.TimeOfDay); // Only time part
                    cmd.Parameters.AddWithValue("@eEndTime", ev.endTime.TimeOfDay);     // Only time part
                    cmd.Parameters.AddWithValue("@eIsPublic", ev.ispublic);
                    cmd.Parameters.AddWithValue("@eNeedTicketing", ev.needTicketing);
                    cmd.Parameters.AddWithValue("@eNeedParticipationConfirmation", ev.needConfirmation);
                    cmd.Parameters.AddWithValue("@eNeedLocation", ev.needLocation);
                    cmd.Parameters.AddWithValue("@eCapacity", ev.participantCount);
                    cmd.Parameters.AddWithValue("@eMaxCapacity", ev.maxParticipantCount);
                    cmd.Parameters.AddWithValue("@eTicketCount", ev.ticketCount);
                    cmd.Parameters.AddWithValue("@eTicketPrice", ev.ticketValue);
                    cmd.Parameters.AddWithValue("@eBudget", ev.eventBudget);
                    cmd.Parameters.AddWithValue("@eMaxBudget", ev.maxBudget);
                    cmd.Parameters.AddWithValue("@eIsActive", ev.isActive);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error [Location: EventHelper.cs UpdateEvent()]" + ex);
                }
            }
        }

        public void addTicketingInfo(int eventId,int TicketCount)
        {
            string query = "INSERT INTO event_ticket_details (eventId,ticketCount,availableBalance) VALUES(@eventId,@ticketCount,@balance)";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eventId",eventId);
                    cmd.Parameters.AddWithValue("@ticketCount", TicketCount);
                    cmd.Parameters.AddWithValue("@balance", TicketCount);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void addPatricipationInfo(int eventId, int TicketCount)
        {
            string query = "INSERT INTO event_participation_details (eventId,slotsCount,availableBalance) VALUES(@eventId,@slotsCount,@balance)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    cmd.Parameters.AddWithValue("@slotsCount", TicketCount);
                    cmd.Parameters.AddWithValue("@balance", TicketCount);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




    }
}
