using System;
using System.Collections.Generic;
using System.Linq;
using Syn.Bot.Siml;
using Syn.VA.Extensions;
using Syn.VA.Interfaces;

namespace FinBot.Engine
{
    public class CategoriesBudgetRepository
    {
        private const string CategoriesBudget = "categories-budget";

        public static void SetCategoryBudget(Context context, string category, decimal budget)
        {
            IVariable categoriesBudget = context.User.Settings[CategoriesBudget];
            categoriesBudget.Add(new Tuple<string, decimal>(category, budget));
        }

        public static Tuple<string, decimal> GetCategoriesBudget(Context context, string category)
        {
            IVariable categoriesBudget = context.User.Settings[CategoriesBudget];
            IEnumerable<Tuple<string, decimal>> enumerable = categoriesBudget.GetTuples<string, decimal>();
            return enumerable.FirstOrDefault(touple => touple.Item1.EqualsWithoutCase(category));
        }
    }
}