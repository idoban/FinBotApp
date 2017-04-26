using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class BalanceAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public BalanceAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            var balance = _financialServices.GetBalance();
            return string.Format("Your balance is {0} dollars", balance);
        }
    }
}