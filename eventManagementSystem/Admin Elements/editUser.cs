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

namespace eventManagementSystem.admin
{
    public partial class editUser : UserControl
    {
        public editUser()
        {
            InitializeComponent();
        }
        public string role;
        public string rowId;
        public int loc;

        public string status;
        private void load(object sender, EventArgs e)
        {
            userRoleTextbox.SelectedIndex = 0;

            passwordTextbox.Visible = false;
            passwordLabel.Visible = false;


            adminForm2 parent = this.FindForm() as adminForm2;
            role = parent.userRole;
            rowId = parent.event_row_Id;
            try
            {
                UserHelper hp = new UserHelper();
                Admin am = hp.returnAdmin(rowId);

                if (am != null)
                {
                    if(am.userRole == "Admin")
                    {
                        loc = 0;
                    }
                }

                if (am.userStatus == "Password Reset")
                {
                    status = "Password Reset";
                    accountStatusBox.SelectedIndex = 1;
                    passwordresetButton.Visible = false;
                    passwordResetLabel.Visible = false;
                    accountStatusBox.Enabled = false;
                    
                }
                else if (am.userStatus=="Active")
                {
                    status = "Active";
                    accountStatusBox.Items.RemoveAt(1);
                    MessageBox.Show("Status: Active");
                    accountStatusBox.SelectedIndex = 0;
                    passwordresetButton.Visible = true;
                    passwordResetLabel.Visible = true;
                }
                userRoleTextbox.SelectedIndex = loc;
                emailTextbox.Text = am.email;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminForm2 parent = this.FindForm() as adminForm2;
            parent.usersButton.PerformClick();
        }


        private void click(object sender, EventArgs e)
        {
            string role = "Admin";
            string email = emailTextbox.Text;
            string stat = accountStatusBox.Text;
            string password= passwordTextbox.Text;

            if (status == "Active" && stat=="Active")
            {
                UserHelper hp = new UserHelper();
                hp.updateActiveAdmin(rowId, email, role, stat);
                MessageBox.Show("Admin updated Successfully!");
                adminForm2 parent = this.FindForm() as adminForm2;
                parent.usersButton.PerformClick();
            }
            else if(status=="Active"&&stat=="Password Reset")
            {
                UserHelper hp = new UserHelper();
                hp.updatePRAdmin(rowId, email, role, stat, password);
                MessageBox.Show("Admin updated Successfully!");
                adminForm2 parent = this.FindForm() as adminForm2;
                parent.usersButton.PerformClick();
            } 
            else if(status=="Password Reset")
            {
                UserHelper hp = new UserHelper();
                hp.updateActiveAdmin(rowId, email, role, stat);
                MessageBox.Show("Admin updated Successfully!");
                adminForm2 parent = this.FindForm() as adminForm2;
                parent.usersButton.PerformClick();
            }


            //UserHelper hp = new UserHelper();
            //hp.updateActiveAdmin(rowId, email, role, stat);
            //MessageBox.Show("Admin updated Successfully!");
            //adminForm2 parent = this.FindForm() as adminForm2;
            //parent.usersButton.PerformClick();
        }

        

        private void chnage(object sender, EventArgs e)
        {
            if (passwordresetButton.Checked)
            {
                accountStatusBox.Items.Insert(1, "Password Reset");
                accountStatusBox.SelectedIndex = 1;
                accountStatusBox.Enabled = false;

                passwordTextbox.Visible = true;
                passwordLabel.Visible = true;
            }
            else
            {
                accountStatusBox.Items.RemoveAt(1);
                accountStatusBox.SelectedIndex = 0;
                accountStatusBox.Enabled = true;

                passwordTextbox.Visible = false;
                passwordLabel.Visible = false;
            }
        }
    }
}
