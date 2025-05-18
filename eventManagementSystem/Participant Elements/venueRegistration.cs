using eventManagementSystem.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eventManagementSystem
{
    public partial class venueRegistration : UserControl
    {

        public venueRegistration()
        {
            InitializeComponent();
        }

        public DataTable venueImageTable;

        VenueManager manager = null;
        Venue v1 = null;
        public int venueId = 0;

        
        public byte[] ImageToBytes(Image image)
        {
            
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public void loadDataGrid(int venueId)
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM venue_eventSpaces_pending where venueId=@id";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", venueId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    eventSpacesGrid.DataSource = table;
                }
                catch (Exception)
                {


                    throw;
                }
            }
        }

        private void venueRegistration_Load(object sender, EventArgs e)
        {
            venueImageTable = new DataTable();
            venueImageTable.Columns.Add("VenueId",typeof(int));
            venueImageTable.Columns.Add("ImageData", typeof(byte[]));

            imageBox01.Visible = false;
            firstnameTextbox.Focus();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(firstnameTextbox.Text) ||
    string.IsNullOrWhiteSpace(lastnameTextbox.Text) ||
    string.IsNullOrWhiteSpace(emailTextbox.Text) ||
    string.IsNullOrWhiteSpace(mobilenumberTextbox.Text) ||
    string.IsNullOrWhiteSpace(nicTextbox.Text) ||
    string.IsNullOrWhiteSpace(profileimageTextbox.Text) ||
    string.IsNullOrWhiteSpace(companyroleTextbox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                guna2Button2.Enabled = false;
                panel1.Visible = true;
            }

            


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(companynameTextbox.Text) ||
    string.IsNullOrWhiteSpace(companyaddressTextbox.Text) ||
    string.IsNullOrWhiteSpace(companycontactnumberTextbox.Text) ||
    string.IsNullOrWhiteSpace(companyBRNTextbox.Text) ||
    string.IsNullOrWhiteSpace(companyTINTextbox.Text))
            {
                MessageBox.Show("Please fill in all required company details.");
            }
            else
            {
                guna2Button3.Enabled = false;
                panel2.Visible = true;
                string companyName = companynameTextbox.Text;
                string companyAddress = companyaddressTextbox.Text;
                string contactNumber = companycontactnumberTextbox.Text;
                string brn = companyBRNTextbox.Text;
                string tin = companyTINTextbox.Text;
                v1 = new Venue("", "", "", "", "", "", companyName, companyAddress, contactNumber, brn, tin);
            }



        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(venueNameTextbox.Text) ||
    string.IsNullOrWhiteSpace(venuediscriptionTextbox.Text) || 
    string.IsNullOrWhiteSpace(venueaddressTextbox.Text) ||
    string.IsNullOrWhiteSpace(venueemailTextbox.Text) ||
    string.IsNullOrWhiteSpace(venuecontactnumberTextbox.Text))
            {
                MessageBox.Show("Please fill in all required venue details.");
            }
            else
            {
                guna2Button4.Enabled = false;
                panel3.Visible = true;
                v1.venueName = venueNameTextbox.Text;
                v1.venueDisplayName = venuedisplaynameTextbox.Text;
                v1.venueDescription = venuediscriptionTextbox.Text;
                v1.venueAddress = venueaddressTextbox.Text;
                v1.venueEmail = venueemailTextbox.Text;
                v1.venueContactNumber = venuecontactnumberTextbox.Text;
                try
                {
                    VenueHelper helper = new VenueHelper();
                    venueId = helper.addVenueRequest(v1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }
            }

            if (venueImageTable.Rows.Count > 0)
            {
                foreach(DataRow row in venueImageTable.Rows)
                {
                    row["VenueId"] = venueId;
                }

            }
        }


        private void addToListButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eventspaceNameTextbox.Text) ||
    string.IsNullOrWhiteSpace(eventspaceCapacityTextbox.Text) ||  
    string.IsNullOrWhiteSpace(eventspaceDescriptionTextbox.Text) ||
    string.IsNullOrWhiteSpace(eventspacepricemodelTextbox.Text) ||  
    string.IsNullOrWhiteSpace(pricerateTextbox.Text))  
            {
                MessageBox.Show("Please fill in all required event space details.");
            }
            else
            {


                try
                {
                    string eventSpaceName = eventspaceNameTextbox.Text;
                    int eventSpaceCapacity = Convert.ToInt32(eventspaceCapacityTextbox.Text);
                    string eventSpaceDescription = eventspaceDescriptionTextbox.Text;
                    string eventSpacePriceModel = eventspacepricemodelTextbox.Text;
                    int eventSpacePriceRate = Convert.ToInt32(pricerateTextbox.Text);

                    EventSpace space = new EventSpace(venueId, eventSpaceName, eventSpaceCapacity, eventSpacePriceModel, eventSpacePriceRate, eventSpaceDescription);
                    EventSpaceHelper helper = new EventSpaceHelper();
                    helper.addEventSpaceRequest(space);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Pleae enter integer values for the capacity and price rate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }



            }
            loadDataGrid(venueId);
            eventspaceNameTextbox.Text = "";
            eventspaceCapacityTextbox.Text = "";
            eventspaceDescriptionTextbox.Text = "";
            eventspacepricemodelTextbox.Text = "";
            pricerateTextbox.Text = "";






        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextbox.Text;
            string lastName = lastnameTextbox.Text;
            string email = emailTextbox.Text;
            string mobileNumber = mobilenumberTextbox.Text;
            string nicNumber = nicTextbox.Text;
            string profileImage = profileimageTextbox.Text;
            string companyRole = companyroleTextbox.Text;

            manager = new VenueManager(email, firstName, lastName, mobileNumber, nicNumber, profileImage, null, companyRole, "Venue Manager", "Pending", venueId);

            VenueManagerHelper helper = new VenueManagerHelper();
            helper.addVenueManagerRequest(manager);

            if (venueImageTable.Rows.Count > 0)
            {
                MessageBox.Show("Congrats, it contains data!!!");
                MessageBox.Show(venueImageTable.Rows.Count.ToString());
            }
            VenueHelper hl = new VenueHelper();
            hl.venueImageRequest(venueImageTable);

            MessageBox.Show("Thank you for your time! You will soon recieve an email to confirm your registration.");
            venueRegisterForm parent = this.FindForm() as venueRegisterForm;
            parent.Close();


        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            if (venueImageTable.Rows.Count >= 5)
            {
                MessageBox.Show("The maximum number of images you can add is 5");
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageBox01.Image = new Bitmap(ofd.FileName);
                }
                if (imageBox01 != null)
                {
                    byte[] imagedata = ImageToBytes(imageBox01.Image);
                    venueImageTable.Rows.Add(0, imagedata);
                    imageCountLabel.Text = $"Image Count: {venueImageTable.Rows.Count}";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
