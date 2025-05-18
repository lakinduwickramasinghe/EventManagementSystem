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
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }
        public string selectedId = null;

        private void infoForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            organizerView reg = new organizerView();
            mainPanel.Controls.Add(reg);
            UserHelper hp = new UserHelper();
            Organizer_REQ org = hp.returnRequest(selectedId);

            reg.firstnameTextbox.Text = org.firstName;
            reg.firstnameTextbox.Enabled = false;

            reg.lastnameTextbox.Text = org.lastName;
            reg.lastnameTextbox.Enabled = false ;

            reg.emailTextbox.Text = org.email;
            reg.emailTextbox.Enabled = false ;

            reg.mobileTextbox.Text = org.mobileNumer;
            reg.mobileTextbox.Enabled = false ;

            reg.profileTextbox.Text = org.profileImage;
            reg.profileTextbox.Enabled = false ;

            reg.moreinfoTextbox.Text = org.moreInfo;
            reg.moreinfoTextbox.Enabled = false ;

            reg.requestButton.Text = "Close";
        }
    }
}
