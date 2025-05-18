using eventManagementSystem.admin;
using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace eventManagementSystem
{
    public partial class viewVenue : UserControl
    {
        public viewVenue()
        {
            InitializeComponent();
        }

        public void comfirmationEmail(int password, string recieverMail, string recieverFirstName)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lakindusudaraka@gmail.com");
                mail.To.Add(recieverMail);
                mail.Subject = "Venue Registration Approved: Your One-Time Password";

                string userName = recieverFirstName;
                string oneTimePassword = password.ToString();
                string companyName = "EMS";

                string emailBodyTemp = @"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333333;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }
        .header {
            background-color: #4CAF50;
            color: #ffffff;
            text-align: center;
            padding: 20px;
        }
        .content {
            padding: 30px;
            line-height: 1.6;
        }
        .content h1 {
            font-size: 24px;
            margin-bottom: 20px;
        }
        .content p {
            margin-bottom: 20px;
        }
        .password-box {
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            padding: 15px;
            text-align: center;
            font-size: 18px;
            font-weight: bold;
            color: #4CAF50;
            margin-bottom: 30px;
            border-radius: 5px;
        }
        .footer {
            background-color: #333333;
            color: #ffffff;
            text-align: center;
            padding: 15px;
            font-size: 14px;
        }
        .footer a {
            color: #4CAF50;
            text-decoration: none;
        }
        .footer a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <!-- Add your logo here -->
            <h2>[Your Company Name]</h2>
        </div>
        <div class='content'>
            <h1>Your Venue Registration Has Been Approved!</h1>
            <p>Dear [User Name],</p>
            <p>We are excited to inform you that your venue has been approved and added to our system. Congratulations!</p>
            
            <div class='password-box'>
                Your One-Time Password: [[One-Time Password]]
            </div>

            <p>Please use the email address you provided during registration to sign in. This one-time password is valid only for your first login. After that, you will be prompted to set up a new password.</p>
            <p>If you have any questions or need further assistance, please contact our support team.</p>
        </div>
        <div class='footer'>
            <p>Thank you for partnering with [Your Company Name].</p>
            <p>Follow us on <a href='#'>Facebook</a> | <a href='#'>Twitter</a> | <a href='#'>Instagram</a></p>
            <p>&copy; 2024 [Your Company Name]. All rights reserved.</p>
        </div>
    </div>
</body>
</html>";

                string emailBody = emailBodyTemp
                    .Replace("[User Name]", userName)
                    .Replace("[[One-Time Password]]", oneTimePassword)
                    .Replace("[Your Company Name]", companyName);

                mail.Body = emailBody;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("lakindusudaraka@gmail.com", "rghvhsuhtnifensj");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show($"Email sent to {recieverMail} successfully!");
            }
            catch (SmtpFailedRecipientException)
            {
                MessageBox.Show("The email provided for this registration could not be delivered.", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("The email provided for this registration is not in the correct format. Could not send the email.", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



        Random random = new Random();

        public void datagridload()
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM venue";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    venueDataGrid.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void viewVenue_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn approveBtn = new DataGridViewButtonColumn();
            approveBtn.Name = "Approve";
            approveBtn.Text = "Approve";
            approveBtn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn declineBtn = new DataGridViewButtonColumn();
            declineBtn.Name = "Decline";
            declineBtn.Text = "Decline";
            declineBtn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn infoButton = new DataGridViewButtonColumn();
            infoButton.Name = "Info";
            infoButton.Text = "Info";
            infoButton.UseColumnTextForButtonValue = true;

            venueRequestsGrid.Columns.Add(approveBtn);
            venueRequestsGrid.Columns.Add(declineBtn);
            venueRequestsGrid.Columns.Add(infoButton);


            venueRequestsGrid.Visible = false;

            
            infoButton.Text = "MoreInfo";
            infoButton.Name = "MoreInfo";
            infoButton.UseColumnTextForButtonValue = true;

            datagridload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venueRegisterForm form = new venueRegisterForm();
            form.ShowDialog();
        }

        private void organizerButton_Click(object sender, EventArgs e)
        {


            venueRequestsGrid.Visible=true;

            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM venue_pending";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    venueRequestsGrid.DataSource = table;
                }
                catch (Exception)
                {


                    throw;
                }
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            venueRequestsGrid.Visible=false;
        }

        private void venueRequestsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {


                DataGridViewColumn column = venueRequestsGrid.Columns[e.ColumnIndex];

                string id = venueRequestsGrid.Rows[e.RowIndex].Cells["venueId"].Value.ToString();

                if (column.Name == "Approve")
                {
                    VenueHelper helper = new VenueHelper();

                    Venue ven = helper.getVenueById(Convert.ToInt32(id));
                    int venueId = helper.addVenue(ven);
                    helper.deleteRequest(Convert.ToInt32(id));

                    int password = random.Next(100000,999999);
                    VenueManagerHelper help = new VenueManagerHelper();
                    VenueManager manager =  help.GetVenueManagerById(Convert.ToInt32(id));
                    help.addVenueManager(manager, venueId,password);
                    help.deleteRequest(Convert.ToInt32(id));

                    comfirmationEmail(password,manager.email,manager.firstName);
                    organizerButton.PerformClick();

                    EventSpaceHelper hl = new EventSpaceHelper();
                    DataTable eventSpaces =  hl.returnVenueSpaces(Convert.ToInt32(id));
                    hl.addEventSpaces(eventSpaces, venueId);
                    hl.deleteRequest(Convert.ToInt32(id));

                    VenueHelper h = new VenueHelper();
                    DataTable VenueImages =  h.GetVenueImagesByVenueId(Convert.ToInt32(id));
                    h.addvenueImage(VenueImages,venueId);
                    h.removevenueImageRequest(Convert.ToInt32(id));

                    adminForm2 parent = this.FindForm() as adminForm2;
                    parent.venuesButton.PerformClick();



                }
                else if (column.Name == "Decline")
                {
                    var answer = MessageBox.Show("Are You Sure? ", "Action Confirmation Needed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        VenueHelper helper = new VenueHelper();
                        helper.deleteRequest(Convert.ToInt32(id));

                        EventSpaceHelper help = new EventSpaceHelper();
                        help.deleteRequest(Convert.ToInt32(id));

                        VenueManagerHelper hl = new VenueManagerHelper();
                        hl.deleteRequest(Convert.ToInt32(id));

                        VenueHelper h = new VenueHelper();
                        h.removevenueImageRequest(Convert.ToInt32(id));

                        organizerButton.PerformClick();
                    }
                }
                else if (column.Name == "MoreInfo")
                { 
                    venueDisplay disp = new venueDisplay();
                    disp.VenueId = id;
                    disp.ShowDialog();

                }
            }
        }
    }
}
