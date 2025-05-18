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
    public partial class organizerRegistrationForm : Form
    {
        public organizerRegistrationForm()
        {
            InitializeComponent();
        }

        private void organizerRegistrationForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            organizerRegister reg= new organizerRegister();
            mainPanel.Controls.Add(reg);
        }
    }
}
