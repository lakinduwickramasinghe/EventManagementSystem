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
    public partial class expenseView : UserControl
    {
        public expenseView()
        {
            InitializeComponent();
        }

        private void load(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                string query = "SELECT * FROM event_expense";
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        expenseDataGrid.DataSource = table;
                    }
                    catch (Exception)
                    {


                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            categorisForm form = new categorisForm();
            form.ShowDialog();
        }
    }
}
