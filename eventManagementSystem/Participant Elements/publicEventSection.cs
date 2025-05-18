using eventManagementSystem.admin;
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

namespace eventManagementSystem.Class
{
    public partial class publicEventSection : UserControl
    {
        public publicEventSection()
        {
            InitializeComponent();
        }

        private void publicEventSection_Load(object sender, EventArgs e)
        {

        }

        private void ticketButton_Click(object sender, EventArgs e)
        { 

            if(LoginInfo.userEmail==null || LoginInfo.userRole == null)
            {
                participationDashboard parent = this.FindForm() as participationDashboard;  
                MessageBox.Show("please sign in before booking a ticket!");
                LoginForm fomr = new LoginForm(parent);
                fomr.StartPosition = FormStartPosition.CenterScreen;
                fomr.ShowDialog();
            }
            else
            {
                participationDashboard db = this.FindForm() as participationDashboard;
                db.backButton.Visible = true;

                if (ticketButton.Text == "Find Tickets")
                {
                    participationDashboard parent = this.FindForm() as participationDashboard;
                    parent.mainPanel.Controls.Clear();
                    TicketView view = new TicketView(Convert.ToInt32(ticketButton.Tag));
                    parent.mainPanel.Controls.Add(view);
                }
                else if (ticketButton.Text == "Confirm Participation")
                {
                    participationDashboard parent = this.FindForm() as participationDashboard;
                    parent.mainPanel.Controls.Clear();
                    PartitipationConfirm confirm = new PartitipationConfirm(Convert.ToInt32(ticketButton.Tag));
                    parent.mainPanel.Controls.Add(confirm);
                }
            }


        }
    }
}
