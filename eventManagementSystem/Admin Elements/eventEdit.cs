using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.admin
{
    public partial class eventEdit : UserControl
    {
        public eventEdit()
        {
            InitializeComponent();
        }

        public string eventId;

        private void load(object sender, EventArgs e)
        {
            ticketCountTextbox.Enabled = false;
            ticketValueTextbox.Enabled = false;
            adminForm2 parent = this.FindForm() as adminForm2;
            eventId = parent.event_row_Id;

            EventHelper hp = new EventHelper();
            Event ev = hp.returnEvent(eventId);
            eventNameTextbox.Text = ev.eventName;
            displayNameTextbox.Text = ev.displayName;
            eventTypeCombobox.Text = ev.eventType;

            eventDatePicker.Value = ev.eventDate;
            startTimePicker.Value = ev.startTime;
            endTimePicker.Value = ev.endTime;

            isPublicButton.Checked = ev.ispublic;
            eventStatusButton.Checked = ev.isActive;
            needTicketingButton.Checked = ev.needTicketing;
            needLocationButton.Checked = ev.needLocation;
            needConfirmationButton.Checked = ev.needConfirmation;

            participantCountTextbox.Value = ev.participantCount;
            maxParticipantTextbox.Value = ev.maxParticipantCount;
            budgetTextbox.Value = ev.eventBudget;
            maxBudgetTextbox.Value = ev.maxBudget;
            ticketCountTextbox.Value = ev.ticketCount;
            ticketValueTextbox.Value = ev.ticketValue;




        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            adminForm2 parent = this.FindForm() as adminForm2;
            parent.eventsButton.PerformClick();
        }

        private void updateEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(eventNameTextbox.Text) ||
    string.IsNullOrEmpty(displayNameTextbox.Text) ||
    string.IsNullOrEmpty(eventTypeCombobox.Text) ||
    string.IsNullOrEmpty(participantCountTextbox.Text) ||
    string.IsNullOrEmpty(maxParticipantTextbox.Text) ||
    string.IsNullOrEmpty(ticketCountTextbox.Text) ||
    string.IsNullOrEmpty(ticketValueTextbox.Text) ||
    string.IsNullOrEmpty(budgetTextbox.Text) ||
    string.IsNullOrEmpty(maxBudgetTextbox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                string eventName = eventNameTextbox.Text;
                string displayName = displayNameTextbox.Text;
                string eventType = eventTypeCombobox.Text;
                DateTime eventDate = eventDatePicker.Value;
                DateTime startTime = startTimePicker.Value;
                DateTime endTime = endTimePicker.Value;
                bool isPublic = isPublicButton.Checked;
                bool needTicketing = needTicketingButton.Checked;
                bool needConfirmation = needConfirmationButton.Checked;
                bool needLocation = needLocationButton.Checked;
                int participantCount = int.Parse(participantCountTextbox.Text);
                int maxParticipantCount = int.Parse(maxParticipantTextbox.Text);
                int ticketCount = int.Parse(ticketCountTextbox.Text);
                int ticketValue = int.Parse(ticketValueTextbox.Text);
                bool isActive = eventStatusButton.Checked;
                int eventBudget = int.Parse(budgetTextbox.Text);
                int maxBudget = int.Parse(maxBudgetTextbox.Text);
                byte[] bannerImageData  = null;

                try
                {
                    Event ev = new Event(eventName, displayName, eventType, eventDate, startTime, endTime, isPublic, needTicketing, needConfirmation, needLocation, participantCount, maxParticipantCount, ticketCount, ticketValue, isActive, eventBudget, maxBudget, bannerImageData, adminLoginInfo.userId, adminLoginInfo.userRole);
                    EventHelper hp = new EventHelper();
                    hp.UpdateEvent(ev, eventId);
                    MessageBox.Show(ev.displayName + " Updated Successfully");
                    adminForm2 parent = this.FindForm() as adminForm2;
                    parent.eventsButton.PerformClick();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: "+ ex);
                }


            }


        }
    }
}
