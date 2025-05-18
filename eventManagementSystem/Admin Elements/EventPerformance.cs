using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem.admin
{
    public partial class EventPerformance : UserControl
    {
        public EventPerformance()
        {
            InitializeComponent();
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        private void EventPerformance_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    string query = "select * from event where eIsPublic=1 and eIsActive=1";
                    string query2 = "SELECT SUM(ticketCount) FROM event_ticket_trasaction WHERE eventId=@id";
                    string query3 = "SELECT SUM(personCount) FROM event_confirmations WHERE eventId=@id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        bool isPaid = (bool)row["eNeedTicketing"];
                        if (isPaid==true)
                        {
                            int eventId = (int)row["eId"];
                            string eDisplayName = row["eDisplayName"].ToString();
                            SqlCommand cmd2 = new SqlCommand(query2, conn);
                            cmd2.Parameters.AddWithValue("@id",eventId);
                            string ticketCount = cmd2.ExecuteScalar().ToString();
                            eventStatsSection section = new eventStatsSection();
                            section.eventNameLabel.Text = eDisplayName;
                            section.soldAmountLabel.Text = $"{ticketCount}";
                            panel1.Controls.Add(section);
                        }
                        else
                        {
                            int eventId = (int)row["eId"];
                            string eDisplayName = row["eDisplayName"].ToString();
                            SqlCommand cmd3 = new SqlCommand(query3, conn);
                            cmd3.Parameters.AddWithValue("@id", eventId);
                            string ticketCount = cmd3.ExecuteScalar().ToString();
                            eventStatsSection2 section = new eventStatsSection2();
                            section.eventNameLabel.Text = eDisplayName;
                            section.soldAmountLabel.Text = $"{ticketCount}";
                            panel2.Controls.Add(section);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                

            }
        }
    }
}
