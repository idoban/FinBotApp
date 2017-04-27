using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public interface IExpenseService
    {
        IEnumerable<Category> Categories();

        Category Text2Category(string text);

        ExpenseReport GenerateReport(Category category, Period period);
    }

}