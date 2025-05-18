using eventManagementSystem.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem.admin
{
    public partial class SelectVenue : Form
    {
        public SelectVenue()
        {
            InitializeComponent();
        }


        Random random = new Random();

        private void SelectVenue_Load(object sender, EventArgs e)
        {

            mainPanel.Controls.Clear();
            VenueHelper helper = new VenueHelper();
            DataTable venues = helper.returnVenues();
            foreach (DataRow row in venues.Rows)
            {
                VenueView view = new VenueView();
                int venueId = (int)row["venueId"];
                int num = random.Next(0, 10);
                view.venueNameLabel.Text = row["venueDisplayName"].ToString();
                view.venueAddressLabel.Text = row["venueAddress"].ToString();
                view.eventSpacesLabel.Text = $"Available Event Spaces : {num}";
                view.selectVenueButton.Tag = venueId;
                mainPanel.Controls.Add(view);

                DataTable venueImages = helper.getVenueImages(venueId);
                byte[] imageData = (byte[])venueImages.Rows[0]["imageData"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    view.pb1.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
