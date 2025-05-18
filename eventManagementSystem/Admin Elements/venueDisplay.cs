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
    public partial class venueDisplay : Form
    {
        public venueDisplay()
        {
            InitializeComponent();
        }

        public string VenueId;


        private void venueDisplay_Load(object sender, EventArgs e)
        {
            venueDisplayUserControol dis = new venueDisplayUserControol();
            mainPanel.AutoScrollPosition = new Point(0, 0);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dis);
            
            VenueHelper venuehelper = new VenueHelper();
            Venue v1 = venuehelper.getVenueById(Convert.ToInt32(VenueId));

            dis.venueNameTextbox.Text = v1.venueName;
            dis.venueNameTextbox.Enabled = false;

            dis.venuedisplaynameTextbox.Text = v1.venueDisplayName;
            dis.venuedisplaynameTextbox.Enabled = false ;

            dis.venuediscriptionTextbox.Text = v1.venueDescription;
            dis.venuediscriptionTextbox.Enabled = false ;

            dis.venueaddressTextbox.Text = v1.venueAddress;
            dis.venueaddressTextbox.Enabled = false ;

            dis.venueemailTextbox.Text = v1.venueEmail;
            dis.venueemailTextbox.Enabled = false ;

            dis.venuecontactnumberTextbox.Text = v1.venueContactNumber;
            dis.venuecontactnumberTextbox.Enabled = false ;

            dis.companynameTextbox.Text = v1.companyName;
            dis.companynameTextbox.Enabled = false;

            dis.companyaddressTextbox.Text = v1.companyAddress;
            dis.companyaddressTextbox.Enabled = false;

            dis.companycontactnumberTextbox.Text = v1.companyContactNumber;
            dis.companycontactnumberTextbox.Enabled=false;

            dis.companyBRNTextbox.Text = v1.companyBRN;
            dis.companyBRNTextbox.Enabled = false ;

            dis.companyTINTextbox.Text = v1.companyTIN;
            dis.companyTINTextbox.Enabled = false ;

            EventSpaceHelper espacehelper = new EventSpaceHelper();
            DataTable eventspaces =  espacehelper.returnVenueSpaces(Convert.ToInt32(VenueId));

            dis.eventSpacesGrid.DataSource = eventspaces;

            VenueManagerHelper venueManagerHelper = new VenueManagerHelper();
            VenueManager manager =  venueManagerHelper.GetVenueManagerById(Convert.ToInt32(VenueId));

            dis.firstnameTextbox.Text = manager.firstName;
            dis.firstnameTextbox.Enabled = false;

            dis.lastnameTextbox.Text = manager.lastName;
            dis.lastnameTextbox.Enabled = false;

            dis.emailTextbox.Text = manager.email;
            dis.emailTextbox.Enabled = false ;

            dis.mobilenumberTextbox.Text = manager.mobileNumber;
            dis.mobilenumberTextbox.Enabled = false ;

            dis.nicTextbox.Text = manager.nicNumber;
            dis.nicTextbox.Enabled = false ;

            dis.profileimageTextbox.Text = manager.profileImage;
            dis.profileimageTextbox.Enabled = false ;

            dis.companyroleTextbox.Text = manager.internalRole;
            dis.companyroleTextbox.Enabled = false;
        }
    }
}
