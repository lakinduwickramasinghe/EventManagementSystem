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
    public partial class login_admin : Form
    {
        public login_admin()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            if(adminRadioButton.Checked)
            {
                UserHelper helper = new UserHelper();
                var data = helper.validateAdminLogin(email, password);
                bool isValid = data.Item1;
                string status = data.Item2;
                int userId = data.Item3;
                if(isValid==true)
                {
                    if (status == "Active")
                    {
                        adminLoginInfo.userEmail = email;
                        adminLoginInfo.userRole = "Admin";
                        adminLoginInfo.userId = userId;
                        this.Hide();
                        adminForm2 admin = new adminForm2();
                        admin.Show();
                    }
                    else if (status =="Password Reset")
                    {
                        ResetPasswordAdmin reset = new ResetPasswordAdmin(email,"Admin");
                        reset.StartPosition = FormStartPosition.CenterScreen;
                        reset.ShowDialog();
                    }
                    else if(status == "Inactice")
                    {
                        MessageBox.Show("You cannot log in since your accout is inactive");
                    }
                }
            }
            else if (organizerRadioButton.Checked)
            {
                UserHelper helper = new UserHelper();
                var data = helper.validatOrganizerLogin(email, password);
                bool isValid = data.Item1;
                string status = data.Item2;
                int userId = data.Item3;
                if (isValid == true)
                {
                    if (status == "Active")
                    {
                        adminLoginInfo.userEmail = email;
                        adminLoginInfo.userRole = "Organizer";
                        adminLoginInfo.userId = userId;
                        this.Hide();
                        OrganizerDashboard admin = new OrganizerDashboard();
                        admin.Show();
                    }
                    else if (status == "Password Reset")
                    {
                        ResetPasswordAdmin reset = new ResetPasswordAdmin(email, "Organizer");
                        reset.StartPosition = FormStartPosition.CenterScreen;
                        reset.ShowDialog();
                    }
                    else if (status == "Inactice")
                    {
                        MessageBox.Show("You cannot log in since your accout is inactive");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select either Admin or Organizer to continue");
            }
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            organizerRegistrationForm form = new organizerRegistrationForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                passwordTextbox.Focus();
            }
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminRadioButton.Checked = true;
                signinButton.PerformClick();
            }
            else if(e.Shift && e.KeyCode == Keys.Up)
            {
                organizerRadioButton.Checked = true;
                signinButton.PerformClick();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            venueRegisterForm reg = new venueRegisterForm();
            reg.StartPosition = FormStartPosition.CenterScreen;
            reg.ShowDialog();
            this.Hide();
        }
    }
}
