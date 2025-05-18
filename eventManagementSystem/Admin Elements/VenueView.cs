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

namespace eventManagementSystem.Usercontrols
{
    public partial class VenueView : UserControl
    {
        public VenueView()
        {
            InitializeComponent();
        }

        private void selectVenueButton_Click(object sender, EventArgs e)
        {
            SelectVenue parent = this.FindForm() as SelectVenue;
            parent.mainPanel.Controls.Clear();
            VenueDetailedView view = new VenueDetailedView(Convert.ToInt32(selectVenueButton.Tag));
            parent.mainPanel.Controls.Add(view);
            
        }
    }
}
