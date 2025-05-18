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

namespace eventManagementSystem.Class
{
    public partial class organizerView : UserControl
    {
        public organizerView()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            infoForm parent = this.FindForm() as infoForm;
            parent.Close();
        }
    }
}
