using eventManagementSystem.Class;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem.admin
{
    public partial class eventDashboard : UserControl
    {
        public eventDashboard()
        {
            InitializeComponent();
        }
        public string selectedId = null;

        private void load(object sender, EventArgs e)
        {
            EventHelper hp = new EventHelper();
            DataTable data = hp.loadEventDatagrid();
            eventDataView.DataSource = data;

        }

        private void eventTableClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = eventDataView.Columns[e.ColumnIndex];
                selectedId = eventDataView.Rows[e.RowIndex].Cells["eId"].Value.ToString();

                adminForm2 parent = this.FindForm() as adminForm2;
                parent.event_row_Id = selectedId;

            }
        }
    }
}