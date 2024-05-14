using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class VacaData
    {
        public string dest { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public TimeSpan lenDays { get; set; }
        public decimal cost { get; set; }
        public int days { get; set; }
        public int numExpenses { get; set; }

        internal List<Expense> expenses = new List<Expense>();
        public VacaData() 
        {
            dest = string.Empty;
            dateStart = DateTime.MinValue;
            dateEnd = DateTime.MinValue;
            cost = 0.00M;
            lenDays = dateEnd - dateStart;
            days = lenDays.Days;
            numExpenses = 0;
        }

        public VacaData(string dest, DateTime dateStart, DateTime dateEnd)
        {
            this.dest = dest;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            cost = 0.00M;
            lenDays = dateEnd - dateStart;
            days = lenDays.Days;
            numExpenses = 0;
        }

        public override string ToString()
        {
            string destination = dest + " : ";
            string from = dateStart.ToShortDateString() + " to ";
            string to = dateEnd.ToShortDateString();
            string str = destination + from + to;
            return str;
        }

        internal void newExpense(Expense expense)
        {
            expenses.Add(expense);
            numExpenses++;
        }

        internal void rmvExpense(int i)
        {
            expenses.RemoveAt(i);
            cost = 0;
            foreach (Expense e in expenses)
            {
                cost += e.cost;
            }
            numExpenses--;
        }
    }
}
