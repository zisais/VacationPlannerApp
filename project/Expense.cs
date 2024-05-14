using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal abstract class Expense
    {
        internal enum ExpenseType {Activity,Accomodation,Travel}
        public string? name { get; set; }
        public decimal cost { get; set; }
        public ExpenseType expense {  get; set; }
        public abstract ExpenseType GetExpenseType();
    }
}
