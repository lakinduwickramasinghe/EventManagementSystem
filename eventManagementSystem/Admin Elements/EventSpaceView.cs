using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.adminForm2;
using static eventManagementSystem.admin.SelectVenue;

namespace eventManagementSystem.admin
{
    public partial class EventSpaceView : UserControl
    {
        VenueDetailedView parent;
        public EventSpaceView(VenueDetailedView uc)
        {
            InitializeComponent();
            this.parent = uc;
        }

        private void selectEventspaceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            parent.selectButton.Enabled = true;
            if (selectEventspaceCheckbox.Checked)
            {
                venueInfo.selectedEventSpace = Convert.ToInt32(selectEventspaceCheckbox.Tag);
            }
            else
            {
                venueInfo.selectedEventSpace = 0;
                parent.selectButton.Enabled = false;
            }


        }
    }
}
