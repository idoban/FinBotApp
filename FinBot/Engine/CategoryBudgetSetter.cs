using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Syn.Bot.Siml;
using Syn.VA.Extensions;
using Syn.VA.Interfaces;

namespace FinBot.Engine
{
    public class CategoryBudgetSetter : BaseAdapter
    {
        public override string Evaluate(Context context)
        {
            XText[] textNodes = context.Element.Nodes().OfType<XText>().ToArray();
            string match = textNodes.First().Value.ToLower();
            string[] parts = match.Split(new [] {"---"}, StringSplitOptions.RemoveEmptyEntries);
            if ( parts.Length < 2) return string.Empty;
            string category = parts[0];
            decimal budget;
            if (!decimal.TryParse(parts[1], out budget)) return string.Empty;

            CategoriesBudgetRepository.SetCategoryBudget(context, category, budget);
            return string.Empty;
        }
    }

    public class CategoryBudgetGetter : BaseAdapter
    {
        public override string Evaluate(Context context)
        {
            XText[] textNodes = context.Element.Nodes().OfType<XText>().ToArray();
            string category = textNodes.First().Value.ToLower();

            var budget = CategoriesBudgetRepository.GetCategoriesBudget(context, category);

            return budget == null ? string.Empty : budget.Item2.ToString();
        }
    }
}