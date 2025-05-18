using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.adminForm2;
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.admin
{
    public partial class eventCreate : UserControl
    {
        public eventCreate()
        {
            InitializeComponent();
        }

        public Image bnImg;

        public byte[] imageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void eventCRUD_Load(object sender, EventArgs e)
        {
            eventStatusButton.Checked = true;
            eventStatusButton.Enabled = false;
            needTicketingLabel.Visible = false;
            needTicketingButton.Visible = false;

            needConfirmationButton.Visible = false;
            needConfirmationLabel.Visible = false;

            if (needTicketingButton.Checked)
            {
                ticketValueLabel.Visible = true;
                ticketValueTextbox.Visible = true;
                ticketCountTextbox.Visible = true;
                ticketCountLabel.Visible = true;
            }
            else
            {
                ticketValueLabel.Visible = false;
                ticketValueTextbox.Visible = false;
                ticketCountTextbox.Visible = false;
                ticketCountLabel.Visible = false;
                ticketValueTextbox.Text = "0";
                ticketCountTextbox.Text = "0";
            }
        }


        private void ticketing_Click(object sender, EventArgs e)
        {
            if (needTicketingButton.Checked)
            {
                ticketValueLabel.Visible = true;
                ticketValueTextbox.Visible = true;
                ticketCountTextbox.Visible = true;
                ticketCountLabel.Visible = true;
            }
            else
            {
                ticketValueLabel.Visible = false;
                ticketValueTextbox.Visible = false;
                ticketCountTextbox.Visible = false;
                ticketCountLabel.Visible = false;
                ticketValueTextbox.Text = "0";
                ticketCountTextbox.Text = "0";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            adminForm2 parent = this.FindForm() as adminForm2;
            parent.eventsButton.PerformClick();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int eventId = 0;
            int tc = 0;
            int pc = 0;
            if (needLocationButton.Checked == true)
            {
                if (venueInfo.selectedVenueId == 0 || venueInfo.selectedEventSpace == 0)
                {
                    MessageBox.Show("Please select a venue to save the event!");
                    SelectVenue venue = new SelectVenue();
                    venue.StartPosition = FormStartPosition.CenterScreen;
                    venue.ShowDialog();
                }
            }
            else
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

                    byte[] bannerImageData = imageToBytes(pb1.Image);

                    tc = Convert.ToInt32(ticketCountTextbox.Text);
                    pc = Convert.ToInt32(participantCountTextbox.Text);


                    Event even = new Event(eventName, displayName, eventType, eventDate, startTime, endTime, isPublic, needTicketing, needConfirmation, needLocation, participantCount, maxParticipantCount, ticketCount, ticketValue, isActive, eventBudget, maxBudget, bannerImageData, adminLoginInfo.userId, adminLoginInfo.userRole);

                    EventHelper helper = new EventHelper();
                    eventId = helper.addEvent(even);

                    adminForm2 parent = this.FindForm() as adminForm2;
                    parent.eventsButton.PerformClick();

                }

                if (needTicketingButton.Checked)
                {
                    EventHelper helper = new EventHelper();
                    helper.addTicketingInfo(eventId, tc);
                }
                else if (needConfirmationButton.Checked)
                {
                    EventHelper eventHelper = new EventHelper();
                    eventHelper.addPatricipationInfo(eventId, pc);
                }
            }



        }

        private void isPublicButton_CheckedChanged(object sender, EventArgs e)
        {
            if(isPublicButton.Checked)
            {
                needTicketingLabel.Visible = true;
                needTicketingButton.Visible = true;

                needConfirmationButton.Visible = true;
                needConfirmationLabel.Visible = true;
            }
            else
            {
                needTicketingLabel.Visible = false;
                needTicketingButton.Visible = false;

                needConfirmationButton.Visible = false;
                needConfirmationLabel.Visible = false;
            }
        }

        private void needTicketingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (needTicketingButton.Checked)
            {
                needConfirmationLabel.Visible=false;
                needConfirmationButton.Visible=false;
            }
            else
            {
                needConfirmationLabel.Visible = true;
                needConfirmationButton.Visible = true;
            }
        }

        private void needConfirmationButton_CheckedChanged(object sender, EventArgs e)
        {
            if(needConfirmationButton.Checked)
            {
                needTicketingButton.Visible=false;
                needTicketingLabel.Visible=false;
            }
            else
            {
                needTicketingButton.Visible = true;
                needTicketingLabel.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pb1.Image = new Bitmap(ofd.FileName);
                    bnImg = new Bitmap(ofd.FileName);

                    if (pb1.Image == null)
                    {
                        MessageBox.Show("PB is null");
                    }
                    else
                    {
                        MessageBox.Show("PB is not null");
                    }

                }
            }
        }

        private void needLocationButton_CheckedChanged(object sender, EventArgs e)
        {
            if (needLocationButton.Checked)
            {
                SelectVenue venue = new SelectVenue();
                venue.StartPosition = FormStartPosition.CenterScreen;
                venue.ShowDialog();
            }
        }
    }
}
