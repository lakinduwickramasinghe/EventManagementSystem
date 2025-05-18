using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem.Class
{
    public partial class PasswordResetForm : Form
    {
        private string email;
        public PasswordResetForm(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }

        private void updatepasswordButton_Click(object sender, EventArgs e)
        {
            if(passwordTextbox.Text != rePasswordTextbox.Text)
            {
                MessageBox.Show("Given password and re entered password does not match!","Passwords does not match",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string newPassword = passwordTextbox.Text;
                try
                {
                    UserHelper helper = new UserHelper();
                    helper.updatePassword(email, newPassword);
                    MessageBox.Show("Password Updated Successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }

        private void v(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rePasswordTextbox.Focus();
            }
        }

        private void n(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updatepasswordButton.PerformClick();
            }
            
        }
    }
}
