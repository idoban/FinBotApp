using System;
using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class CreditCardChangeDateAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreditCardChangeDateAdapter(IFinancialServices financialServices, IDateTimeProvider dateTimeProvider)
        {
            _financialServices = financialServices;
            _dateTimeProvider = dateTimeProvider;
        }

        public override string Evaluate(Context context)
        {
            var cardChargeDate = _financialServices.GetUpcomingCreditCardChargeDate();
            var timeSpan = cardChargeDate.Subtract(_dateTimeProvider.UtcNow.Date);
            return string.Format("Your credit card will be charged in {0}", timeSpan.ToReadableString());
        }
    }
}