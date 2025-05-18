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
    public partial class ResetPasswordAdmin : Form
    {
        private string email;
        private string role;
        public ResetPasswordAdmin(string Email,string Role)
        {
            InitializeComponent();
            this.email = Email;
            this.role = Role;
        }

        private void updatepasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text != rePasswordTextbox.Text)
            {
                MessageBox.Show("Given password and re entered password does not match!", "Passwords does not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string newPassword = passwordTextbox.Text;
                if (role == "Admin")
                {
                    try
                    {
                        UserHelper helper = new UserHelper();
                        helper.updatePasswordAdmin(email, newPassword);
                        MessageBox.Show("Password Updated Successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
                else if(role == "Organizer")
                {
                    try
                    {
                        UserHelper helper = new UserHelper();
                        helper.updatePasswordOrg(email, newPassword);
                        MessageBox.Show("Password Updated Successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }


            }
        }
    }
}
