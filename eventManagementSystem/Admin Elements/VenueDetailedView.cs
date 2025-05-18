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
using static eventManagementSystem.admin.adminForm2;
using static eventManagementSystem.admin.SelectVenue;

namespace eventManagementSystem.admin
{
    public partial class VenueDetailedView : UserControl
    {
        private int venueId;
        public VenueDetailedView(int VenueId)
        {
            InitializeComponent();
            this.venueId = VenueId;
        }
        Random random = new Random();

        Image image01;
        Image image02;
        Image image03;
        Image image04;
        Image image05;

        public int selectedCount = 0;

        private void VenueDetailedView_Load(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            VenueHelper helper = new VenueHelper();
            Venue v = helper.returnVenue(venueId);

            venueNameLabel.Text = v.venueDisplayName;
            venueAddressLabel.Text = v.venueAddress;
            venueDiscriptionTextbox.Text = v.venueDescription;
            venueEmailTextbox.Text = v.venueEmail;
            venueContactNumberTextbox.Text = v.venueContactNumber;

            string[] pbNames = { "pb1", "pb2", "pb3", "pb4", "pb5" };
            int index = 0;

            DataTable images = helper.getVenueImages(venueId);
            foreach (DataRow row in images.Rows)
            {
                byte[] imgInfo = (byte[])row["imageData"];
                PictureBox pb = (PictureBox)this.Controls[pbNames[index]];
                using (MemoryStream ms = new MemoryStream(imgInfo))
                {
                    pb.Image = Image.FromStream(ms);
                }
                index += 1;
            }
            image01 = pb1.Image;
            image02 = pb2.Image;
            image03 = pb3.Image;
            image04 = pb4.Image;
            image05 = pb5.Image;

            mainPanel2.Controls.Clear();
            EventSpaceHelper hl = new EventSpaceHelper();
            DataTable eventSpaces = hl.returnVS(venueId);
            foreach (DataRow row in eventSpaces.Rows)
            {
                EventSpaceView view = new EventSpaceView(this);
                int eventSpaceId = (int)row["eventSpaceId"];
                view.eventspaceNameLabel.Text = row["eventSpceName"].ToString();
                view.eventspaceTypeLabel.Text = row["eventSpaceDiscription"].ToString();
                int capacity = (int)row["eventSpaceCapacity"];
                view.eventspaceCapacityLabel.Text = $"Capacity : {capacity}";
                string priceModel = row["eventSpacePriceModel"].ToString();
                view.eventspacePriceModelLabel.Text = $"Price Model : {priceModel}";
                int priceRate = (int)row["eventSpacePriceRate"];
                view.eventspacePriceRateLabel.Text = $"Rate: LKR {priceRate}";
                view.selectEventspaceCheckbox.Tag = eventSpaceId;
                mainPanel2.Controls.Add(view);
            }

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            pb1.Image = image02;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            pb1.Image = image03;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            pb1.Image = image04;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            pb1.Image = image05;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            SelectVenue parent = this.FindForm() as SelectVenue;

            parent.mainPanel.Controls.Clear();
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
                parent.mainPanel.Controls.Add(view);

                DataTable venueImages = helper.getVenueImages(venueId);
                byte[] imageData = (byte[])venueImages.Rows[0]["imageData"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    view.pb1.Image = Image.FromStream(ms);
                }
            }
        }

        private void pb1_DoubleClick(object sender, EventArgs e)
        {
            pb1.Image = image01;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            venueInfo.selectedVenueId = venueId;
            if (venueInfo.selectedEventSpace == 0)
            {
                MessageBox.Show("Please select an event space to continue");
            }
            else
            {
                SelectVenue parent = this.FindForm() as SelectVenue;
                parent.Close();
            }
        }
    }
}
