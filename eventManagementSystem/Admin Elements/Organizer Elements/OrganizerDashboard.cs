using eventManagementSystem.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventManagementSystem.admin.participationDashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace eventManagementSystem.Class
{
    public partial class OrganizerDashboard : Form
    {
        public OrganizerDashboard()
        {
            InitializeComponent();
        }


        public DataTable getDataFromDatabase(string columnName, string columnName2, string tableName, int orgId)
        {

            string query = $"SELECT {columnName}, {columnName2} FROM {tableName} WHERE eCreatedBy={orgId} AND eCreatorRole='Organizer';";

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

        public int num = 0;



        private void OrganizerDashboard_Load(object sender, EventArgs e)
        {
            userEmailLabel.Text = adminLoginInfo.userEmail;
            eventsButton.PerformClick();
            dashboardButton.PerformClick();

            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;

            string date = DateTime.Now.ToString();
            dateLabel.Text = date;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;


            addNewButton.Visible = false;
            deleteButton.Visible = false;

            OrganizerDefaultDashboard def = new OrganizerDefaultDashboard();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(def);
            pageTitle.Text = "Dashboard";

            dashboardButton.FillColor = Color.FromArgb(80, 138, 168);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
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

            addNewButton.Visible = true;
            deleteButton.Visible = true;


            buttonsPanel.Visible = true;

            EventDashboard_organizer dashboard = new EventDashboard_organizer();

            event_row_Id = dashboard.selectedId;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);

            pageTitle.Text = "Events";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(80, 138, 168);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void expensessButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = true;
            selecteventCombobox.Visible = true;

            expenseView view = new expenseView();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(view);

            addNewButton.Visible = false;
            deleteButton.Visible = false;

            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(80, 138, 168);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);

            DataTable table = getDataFromDatabase("eId", "eName", "event", adminLoginInfo.userId);

            selecteventCombobox.DataSource = table;
            selecteventCombobox.DisplayMember = "eName";
            selecteventCombobox.ValueMember = "eId";

            selecteventCombobox.SelectedIndex = -1;
            num = 1;
        }

        private void venuesButton_Click(object sender, EventArgs e)
        {
            ViewVenue_organizer venue = new ViewVenue_organizer();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(venue);

            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;


            addNewButton.Visible = false;
            deleteButton.Visible = false;

            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(80, 138, 168);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            event_row_Id = null;

            addNewButton.Visible = false;
            deleteButton.Visible = false;



            uv = new userview();


            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uv);
            pageTitle.Text = "Users";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(2, 25, 38);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            addNewButton.Visible = false;
            deleteButton.Visible = false;
            mainPanel.Controls.Clear();
            EventCreate_Organizer crud = new EventCreate_Organizer();
            mainPanel.Controls.Add(crud);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (event_row_Id != null)
            {
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
            if (event_row_Id == null)
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
            if (event_row_Id == null)
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

        private void getSupportButton_Click(object sender, EventArgs e)
        {
            SupportForm form = new SupportForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            addexpenseButton.Visible = false;

            selecteventLabel.Visible = false;
            selecteventCombobox.Visible = false;

            addNewButton.Visible = false;
            deleteButton.Visible = false;

            mainPanel.Controls.Clear();
            EventPerformance_organizer perf = new EventPerformance_organizer();
            mainPanel.Controls.Add(perf);
            pageTitle.Text = "Event Performance";
            dashboardButton.FillColor = Color.FromArgb(2, 25, 38);
            eventsButton.FillColor = Color.FromArgb(2, 25, 38);
            ticketsButton.FillColor = Color.FromArgb(80, 138, 168);
            reportsButton.FillColor = Color.FromArgb(2, 25, 38);
            expensessButton.FillColor = Color.FromArgb(2, 25, 38);
            venuesButton.FillColor = Color.FromArgb(2, 25, 38);
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
                AddExpense_organizer ex = new AddExpense_organizer();
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ex);
                addexpenseButton.Visible = false;
            }
        }

        private void OrganizerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminLoginInfo.userEmail = null;
            adminLoginInfo.userRole = null;
            adminLoginInfo.userId = 0;
        }
    }
}