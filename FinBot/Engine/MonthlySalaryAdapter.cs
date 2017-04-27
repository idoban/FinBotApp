using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class MonthlySalaryAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public MonthlySalaryAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            return _financialServices.GetMonthlySalary().ToString();
        }
    }
}