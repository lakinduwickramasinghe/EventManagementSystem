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
    public partial class venueDisplayUserControol : UserControl
    {
        public venueDisplayUserControol()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            venueDisplay parent = this.FindForm() as venueDisplay;
            parent.Close();
        }

        private void venueDisplayUserControol_Load(object sender, EventArgs e)
        {
        }
    }
}
