using eventManagementSystem.admin;
using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem
{
    public partial class viewCategories : UserControl
    {
        public viewCategories()
        {
            InitializeComponent();
        }

        public void loadDataGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM expense_categories";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    categorisDataGrid.DataSource = table;
                }
                catch (Exception)
                {


                    throw;
                }
            }
        }

        private void viewCategories_Load(object sender, EventArgs e)
        {
            loadDataGrid();
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            categorisDataGrid.Columns.Add(deleteButton);

           
        }

        private void categorisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = categorisDataGrid.Columns[e.ColumnIndex];

                string id = categorisDataGrid.Rows[e.RowIndex].Cells["categoryId"].Value.ToString();


                if (column.Name == "Delete")
                {
                    ExpenseHelper helper = new ExpenseHelper();
                    helper.deleteExpenseCategory(id);
                    loadDataGrid();
                }
            }
        }
    }
}
