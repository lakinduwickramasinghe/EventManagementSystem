using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.admin
{
    public partial class LoginForm : Form
    {
        private participationDashboard dashboardReferance;
        public LoginForm(participationDashboard db)
        {
            InitializeComponent();
            dashboardReferance = db;
            
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            SignupForm signupForm = new SignupForm(dashboardReferance);
            signupForm.StartPosition = FormStartPosition.CenterScreen;
            signupForm.ShowDialog();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            ParticipantHelper helper = new ParticipantHelper();
            bool isValid = helper.participantLoginValidate(email,password);
            UserHelper helper1 = new UserHelper();
            string accoutStatus = helper1.checkAccountStatus(email);

            if (isValid==true)
            {
                if(accoutStatus=="Password Reset")
                {
                    PasswordResetForm form = new PasswordResetForm(email);
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login Successfull!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginInfo.userEmail = email;
                    LoginInfo.userRole = "Participant";
                    dashboardReferance.dataLoadButton.PerformClick();
                    this.Close();
                }

            }
            else if (isValid == false)
            {
                
            }
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTextbox.Focus();
            }
        }

        private void ddown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinButton.PerformClick();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountRecoveryForm form = new AccountRecoveryForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
