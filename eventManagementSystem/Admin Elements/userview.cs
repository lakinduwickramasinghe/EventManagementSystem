using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace eventManagementSystem.admin
{
    
    public partial class userview : UserControl
    {
        public userview()
        {
            InitializeComponent();
        }
        Random random = new Random();

        public string selectedId;
        public string selectedUser = "Admin";

        public void comfirmationEmail(int password,string recieverMail,string recieverFirstName)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lakindusudaraka@gmail.com");
                mail.To.Add(recieverMail);
                mail.Subject = "Organizer Registration Approved: Your One-Time Password";

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
            <h1>Your Organizer Registration Has Been Approved!</h1>
            <p>Dear [User Name],</p>
            <p>We are thrilled to inform you that your request to join us as an organizer has been approved. Welcome aboard!</p>
            
            <div class='password-box'>
                Your One-Time Password: [[One-Time Password]]
            </div>

            <p>Please use the email address you provided during registration to sign in. This one-time password is valid only for your first login. After that, you will be prompted to set up a new password.</p>
            <p>If you have any issues, please reach out to our support team.</p>
        </div>
        <div class='footer'>
            <p>Thank you for choosing [Your Company Name].</p>
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
            catch (Exception)
            {

                throw;
            }
            

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {


            organizerDataGird.Visible = false;
            adminDataGird.Visible = true;
            pendingDataGrid.Visible = false;

            adminForm2 parent = this.FindForm() as adminForm2;
            parent.userRole = "Admin";

            parent.addUserButton.Visible = true;
            parent.editUserButton.Visible = true;
            parent.deleteUserButton.Visible = true;

            parent.deleteUserButton.Location = new Point(435, 10);

            adminButton.FillColor = Color.FromArgb(186, 19, 1);
            organizerButton.FillColor = Color.FromArgb(95, 149, 255);
            hmButton.FillColor = Color.FromArgb(95, 149, 255);

            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM user_admin";
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    adminDataGird.DataSource = table;
                }
                catch (Exception)
                {
                    

                    throw;
                }
            }
        }

        private void load(object sender, EventArgs e)
        {
            adminButton.PerformClick();

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

            pendingDataGrid.Columns.Add(approveBtn);
            pendingDataGrid.Columns.Add(declineBtn);
            pendingDataGrid.Columns.Add(infoButton);


        }

        private void organizerButton_Click(object sender, EventArgs e)
        {
            adminForm2 parent = this.FindForm() as adminForm2;
            parent.addUserButton.Visible = false;
            parent.editUserButton.Visible=false;
            parent.deleteUserButton.Visible=true;
            parent.deleteUserButton.Location = new Point(13, 10);

            parent.userRole = "Organizer";



            adminDataGird.Visible = false;
            organizerDataGird.Visible = true;
            pendingDataGrid.Visible = false;
            

            adminButton.FillColor = Color.FromArgb(95, 149, 255);
            organizerButton.FillColor = Color.FromArgb(186, 19, 1);
            hmButton.FillColor = Color.FromArgb(95, 149, 255);

            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM  user_organizer";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    organizerDataGird.DataSource = table;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void hmButton_Click(object sender, EventArgs e)
        {
            adminButton.FillColor = Color.FromArgb(95, 149, 255);
            organizerButton.FillColor = Color.FromArgb(95, 149, 255);
            hmButton.FillColor = Color.FromArgb(186, 19, 1);

            pendingDataGrid.Visible = true;
            adminDataGird.Visible = false;
            organizerDataGird.Visible=false;


            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "SELECT * FROM  user_organizer_pending";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    pendingDataGrid.DataSource = table;
                }
                catch (Exception)
                {

                    throw;
                }
            }






        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewColumn column = organizerDataGird.Columns[e.ColumnIndex];
                selectedId = organizerDataGird.Rows[e.RowIndex].Cells["userId"].Value.ToString();

                adminForm2 parent = this.FindForm() as adminForm2;
                parent.event_row_Id = selectedId;

            }
        }

        private void click2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewColumn column = adminDataGird.Columns[e.ColumnIndex];
                selectedId = adminDataGird.Rows[e.RowIndex].Cells["auserId"].Value.ToString();

                adminForm2 parent = this.FindForm() as adminForm2;
                parent.event_row_Id = selectedId;

            }

        }

        private void pendingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = pendingDataGrid.Columns[e.ColumnIndex];

                string id = pendingDataGrid.Rows[e.RowIndex].Cells["reqId"].Value.ToString();
                adminForm2 parent = this.FindForm() as adminForm2;
                parent.event_row_Id = id;
                selectedId = id;

                if (column.Name == "Approve")
                {
                    MessageBox.Show("Request Approved!");
                    UserHelper helper = new UserHelper();
                    Organizer_REQ req =  helper.returnRequest(id);

                    int randomPassword = random.Next(100000,999999);
                    string email = req.email;
                    string firstname = req.firstName;
                    string lastname = req.lastName;
                    string mobileNumber = req.mobileNumer;
                    string profileImage = req.profileImage;
                    string password = randomPassword.ToString();
                    string userRole = "Organizer";

                    Organizer org = new Organizer(email,userRole,password,firstname,lastname,mobileNumber,profileImage,"Password Reset");
                    helper.addOrganizer(org);
                    helper.deleteRequest(id);
                    comfirmationEmail(randomPassword,email,firstname);
                    hmButton.PerformClick();


                }
                else if (column.Name == "Decline")
                {
                    UserHelper helper = new UserHelper();
                    helper.deleteRequest(id);
                    hmButton.PerformClick();
                }
                else if (column.Name == "Info")
                {
                    infoForm info = new infoForm();
                    info.selectedId = id;
                    info.ShowDialog();
                }
            }
        }
    }
}
