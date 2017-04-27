using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public class ExpenseReport
    {
        public Category Category { get; set; }
        public decimal Subtotal { get; set; }

        public Period Period { get; set; }
    }
}