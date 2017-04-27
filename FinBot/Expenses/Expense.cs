using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public class Expense
    {
        public decimal Amount { get; set; }
        public Category Category { get; set; }

        public DateTime Date { get; set; }
    }
}