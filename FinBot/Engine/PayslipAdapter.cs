using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class PayslipAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public PayslipAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            var payslipReceived = _financialServices.PayslipReceived();
            return payslipReceived ? "Yes" : "No";
        }
    }
}