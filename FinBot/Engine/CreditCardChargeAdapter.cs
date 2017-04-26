using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class CreditCardChargeAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public CreditCardChargeAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            return _financialServices.GetUpcomingCreditCardChargeAmount().ToString();
        }
    }
}