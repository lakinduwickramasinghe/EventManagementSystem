using eventManagementSystem.Class;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.participationDashboard;

namespace eventManagementSystem.admin
{
    public partial class adminForm2 : Form
    {
        public adminForm2()
        {
            InitializeComponent();
        }

        public DataTable getDataFromDatabase(string columnName,string columnName2, string tableName)
        {
            
            string query = $"SELECT {columnName}, {columnName2} FROM {tableName};";

            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=LAKINDU\\SQLEXPRESS;Initial Catalog=ems;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loc" + ex.Message);
                }
            }
            return table;
        }


        public string event_row_Id = null;

        //Storing the instance of a user control 
        public userview uv;

        public string userRole = null;

        public string eventId;

        public int venueId = 0;

        public static class venueInfo
        {
            public static int selectedEventSpace = 0;
            public static int selectedVenueId = 0;
        }

        public void swichUserControl(UserControl newControl)
        {
            mainPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(newControl);
        }

        private void load(object sender, EventArgs e)
        {
            userEmailLabel.Text = LoginInfo.userEmail;
            eventsButton.PerformClick();
            dashboardButton.PerformClick();

            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            string date = DateTime.Now.ToString();
            dateLabel.Text = date;

        }

        private void btnClick(object sender, EventArgs e)
        {

        }

        private void click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            adminDefaultDashborad def = new adminDefaultDashborad();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(def);
            pageTitle.Text = "Dashboard";

            dashboardButton.FillColor = Color.FromArgb(80, 138, 168);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            event_row_Id = null;
            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            addNewButton.Visible = true;
            deleteButton.Visible = true;
            editButton.Visible = true;


            buttonsPanel.Visible = true;
            eventDashboard dashboard = new eventDashboard();

            event_row_Id = dashboard.selectedId;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);

            pageTitle.Text = "Events";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(80, 138, 168);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            event_row_Id = null;


            addUserButton.Visible = true;
            editUserButton.Visible = true;
            deleteUserButton.Visible = true;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;


            uv = new userview();


            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uv);
            pageTitle.Text = "Users";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(80, 138, 168);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            mainPanel.Controls.Clear();
            EventPerformance perf = new EventPerformance();
            mainPanel.Controls.Add(perf);
            pageTitle.Text = "Event Performance";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(80, 138, 168);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            mainPanel.Controls.Clear();
            pageTitle.Text = "Reports";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(80, 138, 168);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            addNewButton.Visible=false;
            editButton.Visible = false;
            deleteButton.Visible = false;
            mainPanel.Controls.Clear();
            eventCreate crud = new eventCreate();
            mainPanel.Controls.Add(crud);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            eventsButton.PerformClick();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (event_row_Id != null)
            {
                addNewButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;

                eventEdit edit = new eventEdit();
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(edit);
            }
            else
            {
                MessageBox.Show("Please select an event to edit");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (event_row_Id == null)
            {
                MessageBox.Show("Please select an event to delete!");
            }
            else
            {
                var result = MessageBox.Show("Are You Sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EventHelper helper = new EventHelper();
                    helper.deleteEvent(event_row_Id);
                    eventsButton.PerformClick();
                }
                
            }


        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUser user = new addUser();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(user);
            
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if(event_row_Id == null)
            {
                MessageBox.Show("Please select an user to edit!");
            }
            else
            {
                editUser edit = new editUser();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(edit);
            }
            
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if(event_row_Id == null)
            {
                MessageBox.Show("Please select a user to delete");
            }
            else
            {
                if (userRole != null)
                {
                    if (userRole == "Admin")
                    {
                        UserHelper helper = new UserHelper();
                        helper.deleteAdmin(event_row_Id);
                        MessageBox.Show("Admin Deleted Successfully!");
                        adminForm2 parent = this.FindForm() as adminForm2;
                        parent.usersButton.PerformClick();
                    }
                    else if (userRole == "Organizer")
                    {
                        UserHelper helper = new UserHelper();
                        helper.deleteOrganizer(event_row_Id);
                        MessageBox.Show("Organizer Deleted Successfully!");
                        adminForm2 parent = this.FindForm() as adminForm2;
                        parent.usersButton.PerformClick();

                    }
                }
            }
        }

        public int num = 0;

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pageTitle.Text = "Expenses";
            addexpenseButton.Visible = false;

            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            selecteventLabel.Visible = true;
            selecteventCombobox.Visible = true;

            expenseView view = new expenseView();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(view);

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(80, 138, 168);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);

            DataTable table = getDataFromDatabase("eId","eName","event");
            
            selecteventCombobox.DataSource = table;
            selecteventCombobox.DisplayMember = "eName";
            selecteventCombobox.ValueMember = "eId";

            selecteventCombobox.SelectedIndex = -1;
            num = 1;
        }

        private void selecteventCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (num == 1)
            {
                addexpenseButton.Visible = true;
            }

        }

        private void addexpenseButton_Click(object sender, EventArgs e)
        {
            if (selecteventCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event to add an expense");
            }
            else
            {
                eventId = selecteventCombobox.SelectedValue.ToString();
                MessageBox.Show("Event Id :"+ eventId);
                addExpense ex = new addExpense();
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ex);
                addexpenseButton.Visible = false;
            }
        }

        private void venuesButton_Click(object sender, EventArgs e)
        {
            pageTitle.Text = "Venues";
            viewVenue venue = new viewVenue();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(venue);

            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;

            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            usersButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(80, 138, 168);


        }


        private void adminForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminLoginInfo.userEmail = null;
            adminLoginInfo.userRole = null;
            adminLoginInfo.userId = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");

        }
    }
}
