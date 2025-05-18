using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.admin
{
    public class Expense
    {
        public int eventId {  get; set; }
        public int expenseAmount { get; set; }
        public int expenseCategory { get; set; }
        public string expenseRemarks { get; set; }

        public Expense(int EventId,int ExpenseAmount,int ExpenseCategory,string ExpenseRemarks)
        {
            this.eventId = EventId;
            this.expenseAmount = ExpenseAmount;
            this.expenseCategory = ExpenseCategory;
            this.expenseRemarks = ExpenseRemarks;
        }
    }
}
