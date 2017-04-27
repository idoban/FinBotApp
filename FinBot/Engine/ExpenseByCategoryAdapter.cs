using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Syn.Bot.Siml;
using FinBot.Expenses;
using System.Xml.Linq;

namespace FinBot.Engine
{
    public class ExpenseByCategoryAdapter : BaseAdapter
    {
        private IExpenseService ExpenseService { get; }

        public ExpenseByCategoryAdapter(IExpenseService expenseService)
        {
            ExpenseService = expenseService;
        }
        public override string Evaluate(Context context)
        {
            var categoryValue = context.Element.Nodes().OfType<XText>().First().Value;
            var category = ExpenseService.Text2Category(categoryValue);
            return ExpenseService.GenerateReport(category, Period.Monthly).ToString();
        }
    }
}