using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class MonthlyExpensesAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public MonthlyExpensesAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            return _financialServices.GetMonthlyExpenses().ToString();
        }
    }
}