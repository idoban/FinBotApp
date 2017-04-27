using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{   
    public class ExpenseService : IExpenseService
    {
        private IRepository Repository { get; }

        private IEnumerable<Category> DefaultCategroies { get; }

        public ExpenseService(IRepository repository, ICategoriesLoader defaultCategoriesLoader)
        {
            DefaultCategroies = (defaultCategoriesLoader ?? new DefaultCategoriesLoader()).Load();

            Repository = repository;
        }

        public IEnumerable<Category> Categories()
        {
            foreach(var categroy in Repository?.Select<Category>() ?? DefaultCategroies)
            {
                yield return categroy;
            }            
        }

        public Category Text2Category(string text) => 
            (from category in Categories()
            where category.Name.Equals(text, StringComparison.OrdinalIgnoreCase)
            select category).FirstOrDefault();

        public ExpenseReport GenerateReport(Category category, Period period = Period.Monthly) => new ExpenseReport
        {
            Category = category,
            Subtotal = SubTotal(category, period),
            Period   = period
        };

        internal decimal SubTotal (Category category, Period period)
        {
            Func<DateTime, bool> thisMonthExpenses = (date) => date.Month == DateTime.UtcNow.Month;
            Func<DateTime, bool> expenseSelector = thisMonthExpenses;

            if (period != Period.Monthly)
            {
                // Set a different period selector;                    
            }


            var subtotal = (from expense in Repository?.Select<Expense>() ?? Enumerable.Empty<Expense>()
                            where expenseSelector(expense.Date)
                            select expense.Amount)
                           .Sum();

            return subtotal;



        }
    }
}