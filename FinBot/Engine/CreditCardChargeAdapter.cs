using System;
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
            return string.Format("Your upcoming credit card charge is {0} dollars.", _financialServices.GetUpcomingCreditCardChargeAmount());
        }
    }
}