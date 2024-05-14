using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Activity : Expense
    {
        public enum ActivityType {Winter,Summer,Entertainment};
        public ActivityType? activity { get; set; } //nullable to allow for none applicable

        public Activity() { }

        public Activity(string nameA, decimal costA, ExpenseType expenseA, ActivityType activityA)
        {
            name = nameA;
            cost = costA;
            expense = expenseA;
            activity = activityA;
        }
        public void setAll(string nameA, decimal costA, ExpenseType expenseA, ActivityType activityA)
        {
            name = nameA;
            cost = costA;
            expense = expenseA;
            activity = activityA;
        }

        public override ExpenseType GetExpenseType()
        {
            return expense;
        }

        public override string ToString()
        {
            string strCost = String.Format("{0:C}", cost);
            string str = "Expense Type: " + expense +
                "\nActivity Type: " + activity +
                "\nActivity: " + name +
                "\nCost: " + strCost;
            return str;
        }

    }
}
