using eventManagementSystem.Class;
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

namespace eventManagementSystem.admin
{
    public partial class AccountRecoveryForm : Form
    {
        public AccountRecoveryForm()
        {
            InitializeComponent();
        }

        Random random = new Random();

        public string otp;
        public string email;


        public void recoveryEmail(string recieverMail, string recieverFirstName, int password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lakindusudaraka@gmail.com");
                mail.To.Add(recieverMail);
                mail.Subject = "Account Recovery: Your One-Time Password";

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
            color: #333;
        }
        .container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
        }
        h2 {
            color: #2a9df4;
        }
        p {
            font-size: 16px;
            line-height: 1.6;
        }
        .btn {
            display: inline-block;
            margin-top: 20px;
            padding: 10px 15px;
            background-color: #2a9df4;
            color: #ffffff;
            text-decoration: none;
            border-radius: 5px;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h2>Account Recovery for [User Name]</h2>
        <p>It seems like you requested to recover your account on [Your Company Name].</p>
        <p>Please use the following one-time password to recover your account and set up a new password:</p>
        <h3><strong>[One-Time Password]</strong></h3>
        <p>Use this password along with your email to access your account. After logging in, you will be prompted to create a new password for future access.</p>
        <p>If you did not request this recovery, please contact us immediately.</p>
        <p>Best regards,<br/>The [Your Company Name] Team</p>
    </div>
</body>
</html>
";

                string userName = recieverFirstName;
                string oneTimePassword = password.ToString();
                string companyName = "EMS";

                string emailBody = emailBodyTemp
                    .Replace("[User Name]", userName)
                    .Replace("[One-Time Password]", oneTimePassword)
                    .Replace("[Your Company Name]", companyName);

                mail.Body = emailBody;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("lakindusudaraka@gmail.com", "rghvhsuhtnifensj");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show($"Recovery email sent to {recieverMail} successfully!");
            }
            catch (SmtpFailedRecipientException)
            {
                MessageBox.Show("The email provided for account recovery could not be delivered.", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("The email provided for account recovery is not in the correct format. Could not send the email.", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void AccountRecoveryForm_Load(object sender, EventArgs e)
        {
            enterOtpLabel.Visible = false;
            otpTextbox.Visible = false;
            recoverAccountButton.Visible = false;
        }

        private void sendOtpButton_Click(object sender, EventArgs e)
        {


            email = emailTextbox.Text;
            UserHelper helper = new UserHelper();
            bool isExist =  helper.checkForEmail(email);
            if (isExist == true)
            {
                emailTextbox.Enabled = false;
                sendOtpButton.Enabled = false;

                int Otp = random.Next(100000, 999999);
                otp = Otp.ToString();

                try
                {
                    UserHelper help = new UserHelper();
                    help.accountRecovery(email, otp);
                    recoveryEmail(email, email, Otp);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                enterOtpLabel.Visible = true;
                otpTextbox.Visible = true;
                recoverAccountButton.Visible = true;
            }
            else
            {
                MessageBox.Show("We were unable to locate an account associated with the email provided. Please verify the email address and try again.");
                emailTextbox.Enabled = true;
                sendOtpButton.Enabled = true;
            }
        }

        private void recoverAccountButton_Click(object sender, EventArgs e)
        {
            if (otpTextbox.Text == otp)
            {
                this.Hide();
                PasswordResetForm form = new PasswordResetForm(email);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
                
            }
        }
    }
}
