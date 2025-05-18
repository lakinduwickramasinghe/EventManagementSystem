using CrystalDecisions.CrystalReports.Engine;
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
using eventManagementSystem.Class;
using System.Security.Cryptography;

namespace eventManagementSystem.admin
{
    public partial class PaymentGateway : Form
    {
        private int paymentAmount;
        private int ticketCount;
        private int eid;
        public PaymentGateway(int amount, int count, int EventId)
        {
            InitializeComponent();
            this.paymentAmount = amount;
            this.ticketCount = count;
            this.eid = EventId;
        }


        public void SendInvoice(string receiverEmail, string receiverFirstName, string eventName, int ticketCount, decimal ticketPrice)
        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("lakindusudaraka@gmail.com"),
                    Subject = "Invoice for Your Recent Ticket Purchase",
                    IsBodyHtml = true
                };
                mail.To.Add(receiverEmail);

                string subtotal = "LKR " + (ticketCount * ticketPrice).ToString("F2");
                string total = subtotal;

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
        .invoice-table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        .invoice-table th, .invoice-table td {
            padding: 12px;
            border: 1px solid #dee2e6;
            text-align: left;
        }
        .invoice-table th {
            background-color: #f1f3f5;
        }
        .total-row td {
            font-weight: bold;
            background-color: #f1f3f5;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h2>Dear [User Name],</h2>
        <p>Thank you for choosing EMS. We are pleased to provide you with the invoice for your recent ticket purchase. Please find the details below:</p>
        
        <table class='invoice-table'>
            <tr>
                <th>Event Name</th>
                <th>Ticket Count</th>
                <th>Ticket Price</th>
                <th>Subtotal</th>
            </tr>
            <tr>
                <td>[Event Name]</td>
                <td>[Ticket Count]</td>
                <td>[Ticket Price]</td>
                <td>[Subtotal]</td>
            </tr>
            <tr class='total-row'>
                <td colspan='3'>Total</td>
                <td>[Total]</td>
            </tr>
        </table>
        
        <p>If you have any questions or require further assistance, please do not hesitate to contact our support team.</p>
        <p>Thank you for your business. We look forward to serving you again.</p>
        <p>Best regards,<br/>The EMS Team</p>
    </div>
</body>
</html>
";

                string emailBody = emailBodyTemplate
                    .Replace("[User Name]", receiverFirstName)
                    .Replace("[Event Name]", eventName)
                    .Replace("[Ticket Count]", ticketCount.ToString())
                    .Replace("[Ticket Price]", "LKR " + ticketPrice.ToString("F2"))
                    .Replace("[Subtotal]", subtotal)
                    .Replace("[Total]", total);

                mail.Body = emailBody;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25))
                {
                    smtp.Credentials = new NetworkCredential("lakindusudaraka@gmail.com", "rghvhsuhtnifensj");
                    smtp.EnableSsl = true;

                    smtp.Send(mail);
                }

                MessageBox.Show($"Invoice sent to {receiverEmail} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpFailedRecipientException)
            {
                MessageBox.Show("The email could not be delivered to the recipient.", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("The email address format is invalid. Please check the email address and try again.", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void processpaymentButton_Click(object sender, EventArgs e)
        {
            if(cardnumberTextbox.Text=="" || cvnnumberTextbox.Text == "" || cardTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the required data fields");
            }
            else
            {
                string paymentType = cardTypeBox.Text;
                string cardNumber = cardnumberTextbox.Text;
                string cvn = cvnnumberTextbox.Text;

                Payment payment = new Payment(paymentType, cardNumber, cvn, paymentAmount);
                PaymentHelper helper = new PaymentHelper();
                int paymentId = helper.addPayment(payment);

                if (paymentId != 0)
                {
                    try
                    {
                        ParticipantHelper hl = new ParticipantHelper();
                        hl.createTicketTransaction(paymentId, ticketCount, LoginInfo.userEmail, eid);
                        hl.updateTicketBalance(eid, ticketCount);
                        MessageBox.Show("Booking success, you will soon recieve an email confirming it.");
                        EventHelper hlp = new EventHelper();
                        Event eventInfo = hlp.returnEvent(eid.ToString());
                        string dispName = eventInfo.displayName;
                        int ticketPrice = eventInfo.ticketValue;

                        SendInvoice(LoginInfo.userEmail, LoginInfo.userEmail, dispName, ticketCount, ticketPrice);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
            }

        }

        private void PaymentGateway_Load(object sender, EventArgs e)
        {
            amountLabel.Text = $"LKR {paymentAmount} .00";
        }

        private void bw01_DoWork(object sender, DoWorkEventArgs e)
        {


        }
    }
}
