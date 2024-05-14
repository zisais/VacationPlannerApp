using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1.Activity;
using static Project1.Expense;
using System.Xml.Linq;

namespace Project1
{
    internal class Travel : Expense
    {
        public enum TravelType {Car,Plane,Train};
        public TravelType? travel { get; set; } //nullable to allow for none applicable

        public Travel() { }

        public Travel(string nameT, decimal costT, ExpenseType expenseT, TravelType travelT)
        {
            name = nameT;
            cost = costT;
            expense = expenseT;
            travel = travelT;
        }
        public void setAll(string nameT, decimal costT, ExpenseType expenseT, TravelType travelT)
        {
            name = nameT;
            cost = costT;
            expense = expenseT;
            travel = travelT;
        }
        public override ExpenseType GetExpenseType()
        {
            return expense;
        }

        public override string ToString() 
        {
            string str = "Expense Type: " + expense +
                "\nMethod of Travel: " + travel +
                "\nVehicle/Company: " + name +
                "\nCost: " + cost;
            return str;
        }
    }
}
