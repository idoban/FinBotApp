using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class CreditBalanceAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public CreditBalanceAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            return _financialServices.GetCreditCardBalance().ToString();
        }
    }
}