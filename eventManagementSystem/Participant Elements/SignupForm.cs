using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Mail;
using System.Net;
using eventManagementSystem.Class;

namespace eventManagementSystem.admin
{
    public partial class SignupForm : Form
    {
        private participationDashboard mainPage;
        public SignupForm(participationDashboard db)
        {
            InitializeComponent();
            this.mainPage = db;
        }
        public Image img;
        Random random = new Random();
        public int count = 0;

        public void participantEmail(string recieverMail,string recieverFirstName, int password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lakindusudaraka@gmail.com");
                mail.To.Add(recieverMail);
                mail.Subject = "Participant Registration Confirmed: Your One-Time Password";

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
        <h2>Welcome, [User Name]!</h2>
        <p>Thank you for registering as a participant in [Your Company Name].</p>
        <p>Your registration has been successfully completed, and your account is now active.</p>
        <p>Here is your one-time password for first-time login:</p>
        <h3><strong>[One-Time Password]</strong></h3>
        <p>Please use this password along with the email you provided during registration to log in. You will be prompted to set up a new password after your first login.</p>
        <p>If you have any questions or need assistance, feel free to reach out to us.</p>
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

        public bool emailValidation(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            UserHelper hel = new UserHelper();

            bool isExist = hel.checkForEmail(email);
            if(isExist == true)
            {
                MessageBox.Show("This email is already registered. Please log in or use a different email to register");
            }
            else
            {
                string firstname = firstnameTextbox.Text;
                string lastname = lastnameTextbox.Text;
                string mobileNumber = mobilenumberTextbox.Text;

                int password = random.Next(100000, 999999);
                string pw = password.ToString();

                Participant p01 = new Participant(email, "Participant", pw, firstname, lastname, mobileNumber, "Password Reset");


                bool isEmailValid = emailValidation(email);
                if (isEmailValid == false)
                {
                    invalidemailLabel.Visible = true;
                    emailTextbox.Text = "";
                    emailTextbox.Focus();
                    emailTextbox.BackColor = Color.Red;
                }
                else
                {
                    ParticipantHelper helper = new ParticipantHelper();
                    helper.addParticipant(p01);
                    MessageBox.Show("Added");
                    participantEmail(p01.email, p01.firstName, password);
                    this.Close();
                }
            }


            
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            invalidemailLabel.Visible = false;

        }

        private void addprofileimageTextbox_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm(mainPage);
            form.ShowDialog();
            

        }
    }
}
