using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem
{
    public partial class categorisForm : Form
    {
        public categorisForm()
        {
            InitializeComponent();
        }

        public void begining(Panel panel)
        {
            viewCategories cat = new viewCategories();
            panel.Controls.Clear();
            panel.Controls.Add(cat);
        }

        private void categorisForm_Load(object sender, EventArgs e)
        {
            viewCategories cat = new viewCategories();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(cat);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addCategory cat = new addCategory();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(cat);

        }
    }
}
