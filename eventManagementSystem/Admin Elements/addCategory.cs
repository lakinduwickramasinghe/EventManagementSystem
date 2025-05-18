using eventManagementSystem.admin;
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
    public partial class addCategory : UserControl
    {
        public addCategory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = categoryNameTextbox.Text;
                ExpenseHelper hp = new ExpenseHelper();
                hp.addCategory(name);
                MessageBox.Show("Success!");
                categorisForm parent = this.FindForm() as categorisForm;
                Panel panel = parent.mainPanel;
                parent.begining(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
