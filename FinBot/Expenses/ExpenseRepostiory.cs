using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public class ExpenseRepostiory : IRepository<Expense>
    {                        
        public IEnumerable<Expense> Select()
        {
            yield return new Expense { Amount = 10, Category = new Category("Food")          , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 20, Category = new Category("Recreation")    , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 30, Category = new Category("Home")          , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 40, Category = new Category("Utilities")     , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 50, Category = new Category("Clothes")       , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 60, Category = new Category("Education")     , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 70, Category = new Category("Transportation"), Date = DateTime.UtcNow };
            yield return new Expense { Amount = 80, Category = new Category("Insurances")    , Date = DateTime.UtcNow };
            yield return new Expense { Amount = 90, Category = new Category("Presents")      , Date = DateTime.UtcNow };
        }
    }
}