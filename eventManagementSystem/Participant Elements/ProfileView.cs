using eventManagementSystem.Class;
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
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.admin
{
    public partial class ProfileView : UserControl
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            deleteAccountButton.Enabled = false;
            ParticipantHelper helper =new ParticipantHelper();
            DataTable bookings = helper.returnTickets(LoginInfo.userEmail);
            foreach(DataRow row in bookings.Rows)
            {

                int eventId = Convert.ToInt32(row["eventId"]);
                EventHelper hl = new EventHelper();
                Event ev = hl.returnEvent(eventId.ToString());
                
                byte[] imageData = ev.imageData;
                int ticketCount = Convert.ToInt32(row["ticketCount"]);
                bookedEvents section = new bookedEvents();
                section.ticketCountLabel.Text = ticketCount.ToString();
                section.eventNameLabel.Text = ev.displayName;
                section.addressLabel.Text = ev.eventType.ToString();
                section.ticketPriceLabel.Text = $"LKR {ev.ticketValue} .00";
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    section.imageBox.Image = Image.FromStream(ms);
                }
                mainPanel.Controls.Add(section);
            }


            DataTable confirmations = helper.returnConfirmations(LoginInfo.userEmail);
            foreach (DataRow rw in confirmations.Rows)
            {

                int eventId = Convert.ToInt32(rw["eventId"]);
                EventHelper hl = new EventHelper();
                Event ev = hl.returnEvent(eventId.ToString());
                byte[] imageData = ev.imageData;

                int ticketCount = Convert.ToInt32(rw["personCount"]);
                bookedEvents section = new bookedEvents();
                section.ticketCountLabel.Text = ticketCount.ToString();
                section.eventNameLabel.Text = ev.displayName;
                section.addressLabel.Text = ev.eventType.ToString();
                section.ticketPriceLabel.Text = $"LKR {ev.ticketValue} .00";
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    section.imageBox.Image = Image.FromStream(ms);
                }
                mainPanel.Controls.Add(section);
            }


        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordResetForm form = new PasswordResetForm(LoginInfo.userEmail);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
