using eventManagementSystem.admin;
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
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.Class
{
    public partial class EventDashboard_organizer : UserControl
    {
        public EventDashboard_organizer()
        {
            InitializeComponent();
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable loadEventDatagrid()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM event WHERE eCreatedBy=@orgId and eCreatorRole='Organizer'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orgId", adminLoginInfo.userId);

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

        public string selectedId = null;

        private void EventDashboard_organizer_Load(object sender, EventArgs e)
        {
            DataTable data = loadEventDatagrid();
            eventDataView.DataSource = data;
        }

        private void eventDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = eventDataView.Columns[e.ColumnIndex];
                selectedId = eventDataView.Rows[e.RowIndex].Cells["eId"].Value.ToString();

                OrganizerDashboard parent = this.FindForm() as OrganizerDashboard;
                parent.event_row_Id = selectedId;

            }
        }
    }
}
