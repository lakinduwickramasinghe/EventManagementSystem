using eventManagementSystem.Class;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace eventManagementSystem.admin
{
    public partial class participationDashboard : Form
    {
        public participationDashboard()
        {
            InitializeComponent();
        }



        public static class LoginInfo
        {
            public static string userEmail;
            public static string userRole;
        }

        public static class adminLoginInfo
        {
            public static string userEmail;
            public static string userRole;
            public static int userId;
        }

        public bool checkLoginInfo()
        {
            bool isLoggedIn = false;
            if (LoginInfo.userEmail == null && LoginInfo.userRole == null)
            {
                isLoggedIn = false;
            }
            else
            {
                isLoggedIn = true;
            }
            return isLoggedIn;
        }

        private void participationDashboard_Load(object sender, EventArgs e)
        {
            secondaryPanel.Visible = false;
            backButton.Visible = false;
            dataLoadButton.PerformClick();
            helloLabel.Visible = false;
            logoutButton.Visible = false;
        }

        private void dataLoadButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            typeCombobox.SelectedIndex = -1;
            bool isLogin = checkLoginInfo();
            if (isLogin == true)
            {
                signinButton.Visible = false;
                signupButton.Visible = false;
                adminLogin.Visible = false;
                helloLabel.Text = $"Hello {LoginInfo.userEmail}!";
                helloLabel.Visible = true;
                logoutButton.Visible = true;
            }
            else
            {
                signinButton.Visible = true;
                signupButton.Visible = true;
                adminLogin.Visible = true;

                helloLabel.Visible = false;
                logoutButton.Visible = false;
            }
            mainPanel.Controls.Clear();
            EventHelper helper = new EventHelper();
            DataTable eventData = helper.returnPublicEvents();
            foreach (DataRow row in eventData.Rows)
            {
                DateTime date = (DateTime)row["eDate"];
                bool isTicketing = (bool)row["eNeedTicketing"];

                publicEventSection section = new publicEventSection();
                if (isTicketing == true)
                {
                    section.ticketButton.Text = "Find Tickets";
                }
                else
                {
                    section.ticketButton.Text = "Confirm Participation";
                }
                section.eventNameLabel.Text = row["eDisplayName"].ToString();
                section.addressLabel.Text = row["eType"].ToString();
                section.eventtypeLabel.Text = date.ToString("dd/MM/yyyy");
                section.ticketButton.Tag = row["eid"].ToString();
                byte[] image = (byte[])row["eBannerImage"];
                using (MemoryStream ms = new MemoryStream(image))
                {
                    section.imageBox.Image = Image.FromStream(ms);
                }
                mainPanel.Controls.Add(section);

            }
        }

        private void publicEventsButton_Click(object sender, EventArgs e)
        {
            dataLoadButton.PerformClick();
            secondaryPanel.Visible = false;
            mainPanel.Visible = true;
            filtersPanel.Visible = true;
            
        }

        private void change(object sender, EventArgs e)
        {
            EventHelper helper = new EventHelper();
            DataTable table =  helper.returnFilterEvents(typeCombobox.Text);
            mainPanel.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                DateTime date = (DateTime)row["eDate"];
                publicEventSection section = new publicEventSection();
                section.eventNameLabel.Text = row["eDisplayName"].ToString();
                section.addressLabel.Text = row["eType"].ToString();
                section.eventtypeLabel.Text = date.ToString("dd/MM/yyyy");
                section.ticketButton.Tag = row["eid"].ToString();
                byte[] image = (byte[])row["eBannerImage"];
                using (MemoryStream ms = new MemoryStream(image))
                {
                    section.imageBox.Image = Image.FromStream(ms);
                }
                mainPanel.Controls.Add(section);

            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            typeCombobox.SelectedIndex = -1;
            dataLoadButton.PerformClick();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(this);
            signupForm.StartPosition = FormStartPosition.CenterScreen;
            signupForm.ShowDialog();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            if(adminLoginInfo.userEmail==null || adminLoginInfo.userRole == null)
            {
                login_admin admin = new login_admin();
                admin.StartPosition = FormStartPosition.CenterScreen;
                admin.ShowDialog();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginInfo.userEmail);
            MessageBox.Show(LoginInfo.userRole);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginInfo.userEmail = null;
            LoginInfo.userRole = null;
            dataLoadButton.PerformClick();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            secondaryPanel.Visible = false;
            filtersPanel.Visible = true;
            mainPanel.Visible = true;
            publicEventsButton.PerformClick();
            backButton.Visible = false;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (LoginInfo.userEmail == null || LoginInfo.userRole == null)
            {
                participationDashboard parent = this.FindForm() as participationDashboard;
                MessageBox.Show("please sign in to see your profile");
                LoginForm fomr = new LoginForm(parent);
                fomr.StartPosition = FormStartPosition.CenterScreen;
                fomr.ShowDialog();
            }
            else
            {
                secondaryPanel.Visible = true;
                mainPanel.Visible = false;
                filtersPanel.Visible = false;
                backButton.Visible = true;
                dataLoadButton.Visible = false;

                secondaryPanel.Controls.Clear();
                ProfileView view = new ProfileView();
                secondaryPanel.Controls.Add(view);
            }

        }
    }
}
