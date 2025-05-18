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

namespace eventManagementSystem
{
    public partial class ViewVenue_organizer : UserControl
    {
        public ViewVenue_organizer()
        {
            InitializeComponent();
        }

        private void ViewVenue_organizer_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM venue";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    venueRequestsGrid.DataSource = table;
                }
                catch (Exception)
                {


                    throw;
                }
            }
        }
    }
}
