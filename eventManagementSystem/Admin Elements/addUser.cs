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
    public partial class addUser : UserControl
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {

            string role = userRoleTextbox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;

            Admin admin = new Admin(email,role,password,"Reset Password");
            try
            {
                UserHelper helper = new UserHelper();
                helper.addAdmin(admin);
                MessageBox.Show("Admin added successfully!");
                adminForm2 parent = this.FindForm() as adminForm2;
                parent.usersButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
