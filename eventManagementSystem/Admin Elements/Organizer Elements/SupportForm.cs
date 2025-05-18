using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.participationDashboard;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace eventManagementSystem
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }

        public string message;


        public void SendHelpRequest(string adminEmail, string userId, string userEmail, string userMessage)
        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("lakindusudaraka@gmail.com"),
                    Subject = "Help Request from User",
                    IsBodyHtml = true
                };
                mail.To.Add(adminEmail);

                string emailBodyTemplate = @"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #e9ecef;
            color: #495057;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 100%;
            max-width: 600px;
            margin: 40px auto;
            background-color: #ffffff;
            padding: 25px;
            border-radius: 8px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
        }
        h2 {
            color: #007bff;
            font-size: 24px;
            margin-bottom: 20px;
        }
        p {
            font-size: 16px;
            line-height: 1.6;
            margin: 0 0 20px;
        }
        .info {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h2>Help Request Notification</h2>
        <p><strong>User ID:</strong> [UserId]</p>
        <p><strong>User Email:</strong> [UserEmail]</p>
        <p><strong>Message:</strong></p>
        <p>[UserMessage]</p>
        <br>
        <br>
        <br>
        <p><strong>Please take the necessary actions to address this request.</strong></p>
        <p>Best regards,<br/>EMS Support Team</p>
    </div>
</body>
</html>
";

                string emailBody = emailBodyTemplate
                    .Replace("[UserId]", userId)
                    .Replace("[UserEmail]", userEmail)
                    .Replace("[UserMessage]", userMessage);

                mail.Body = emailBody;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("lakindusudaraka@gmail.com", "rghvhsuhtnifensj");
                    smtp.EnableSsl = true;

                    smtp.Send(mail);
                }
            }
            catch (SmtpFailedRecipientException)
            {
                return;
            }
            catch (FormatException)
            {

            }
            catch (Exception)
            {
                return;
            }
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            message = cmessageBox.Text;
            bw3.RunWorkerAsync();
            this.Close();

        }

        private void bw3_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable adminEmails = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string query = "select userEmail from user_admin";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(adminEmails);
                conn.Close();
            }
            foreach (DataRow row in adminEmails.Rows)
            {

                string adminEmail = row["userEmail"].ToString();
                SendHelpRequest(adminEmail, adminLoginInfo.userId.ToString(), adminLoginInfo.userEmail, message);
            }
        }
    }
}
