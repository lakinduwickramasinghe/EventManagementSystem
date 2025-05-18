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
    public partial class venueRegisterForm : Form
    {
        public venueRegisterForm()
        {
            InitializeComponent();
        }

        private void venueRegisterForm_Load(object sender, EventArgs e)
        {
            venueRegistration venueRegisterForm = new venueRegistration();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(venueRegisterForm);
        }
    }
}
