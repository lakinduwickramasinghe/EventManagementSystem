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
    public partial class organizerRegister : UserControl
    {
        public organizerRegister()
        {
            InitializeComponent();
        }

        private void organizerRegister_Load(object sender, EventArgs e)
        {

        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextbox.Text;
            string lastName = lastnameTextbox.Text;
            string email = emailTextbox.Text;
            string phoneNumber = mobileTextbox.Text;
            string profile = profileTextbox.Text;
            string moreInfo = moreinfoTextbox.Text;
            string role = "Organizer";

            Organizer_REQ req = new Organizer_REQ(email,firstName,lastName,phoneNumber,profile,moreInfo,role);


            UserHelper helper = new UserHelper();
            helper.addOrganizerRequest(req);
            MessageBox.Show("Your request have been send to the administration!");

            organizerRegistrationForm parent = this.FindForm() as organizerRegistrationForm;
            parent.Close();

        }

        private void a(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastnameTextbox.Focus();
            }
        }

        private void b(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailTextbox.Focus();
            }
        }

        private void c(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mobileTextbox.Focus();
            }
            
        }

        private void d(object sender, KeyEventArgs e)
        {
        }
    }
}
