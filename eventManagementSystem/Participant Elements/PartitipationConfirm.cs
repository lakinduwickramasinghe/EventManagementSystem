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
    public partial class PartitipationConfirm : UserControl
    {
        private int eventId;
        public PartitipationConfirm(int EventId)
        {
            InitializeComponent();
            this.eventId = EventId;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(countBox.Value);
            participationDashboard parent = this.FindForm() as participationDashboard;
            ParticipantHelper helper = new ParticipantHelper();
            helper.createConfirmation(count, LoginInfo.userEmail,eventId);
            helper.updateparticipationDetails(eventId,count);
            MessageBox.Show("Record saved successfully!");
            parent.backButton.PerformClick();
        }

        private void PartitipationConfirm_Load(object sender, EventArgs e)
        {
            EventHelper helper = new EventHelper();
            Event ev = helper.returnEvent(eventId.ToString());
            eventNameLabel.Text = ev.displayName;
            addressLabel.Text = ev.eventType;
            eventtypeLabel.Text = ev.eventDate.ToString("dd/MM/yyyy");

            using (MemoryStream ms = new MemoryStream(ev.imageData))
            {
                pb1.Image = Image.FromStream(ms);
            }
        }
    }
}
