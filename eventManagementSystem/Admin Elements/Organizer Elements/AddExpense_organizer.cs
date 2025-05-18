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
    public partial class AddExpense_organizer : UserControl
    {
        public AddExpense_organizer()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OrganizerDashboard parent = this.FindForm() as OrganizerDashboard;
            parent.expensessButton.PerformClick();
        }

        private void addexpenseButton_Click(object sender, EventArgs e)
        {
            if (expenseAmountTextbox.Value <= 0)
            {
                MessageBox.Show("You cannot add an expense with the value of 0 or below!");
            }
            else
            {
                OrganizerDashboard parent = this.FindForm() as OrganizerDashboard;
                int eventId = Convert.ToInt32(parent.eventId);
                int expenseAmount = Convert.ToInt32(expenseAmountTextbox.Value);
                int expenseCategory = Convert.ToInt32(expenseCategoryCombobox.SelectedValue);
                string expenseRemarks = expenseRemarksTextbox.Text;

                try
                {
                    Expense ex = new Expense(eventId, expenseAmount, expenseCategory, expenseRemarks);

                    ExpenseHelper hp = new ExpenseHelper();
                    hp.addExpense(ex);
                    MessageBox.Show("Success!");
                    parent.expensessButton.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddExpense_organizer_Load(object sender, EventArgs e)
        {
            adminForm2 admin = new adminForm2();
            DataTable table = admin.getDataFromDatabase("categoryId", "categoryName", "expense_categories");
            expenseCategoryCombobox.DataSource = table;
            expenseCategoryCombobox.DisplayMember = "categoryName";
            expenseCategoryCombobox.ValueMember = "categoryId";
        }
    }
}
