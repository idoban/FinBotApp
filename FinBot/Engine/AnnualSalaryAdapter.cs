using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class AnnualSalaryAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public AnnualSalaryAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            return _financialServices.GetAnnualSalary().ToString();
        }
    }
}