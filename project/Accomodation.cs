using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Accomodation : Expense
    {
        public enum AccomType {Hotel,BNB,Friend}
        public AccomType? accom {  get; set; } //nullable to allow for none applicable

        public Accomodation() { }

        public Accomodation(string nameA, decimal costPerNight, int numDays, ExpenseType expenseA, AccomType accomType)
        {
            name = nameA;
            cost = costPerNight * numDays;
            expense = expenseA;
            accom = accomType;
        }
        public void setAll(string nameA, decimal costPerNight, int numDays, ExpenseType expenseA, AccomType accomType)
        {
            name = nameA;
            cost = costPerNight * numDays;
            expense = expenseA;
            accom = accomType;
        }
        public override ExpenseType GetExpenseType()
        {
            return expense;
        }

        public override string ToString()
        {
            string strCost = String.Format("{0:C}", cost);
            string str = "Expense Type: " + expense +
                "\nAccomodation Type: " + accom +
                "\nName of Residence: " + name +
                "\nCost: " + strCost;
            return str;

        }
    }
}
