using System.Linq;
using System.Xml.Linq;
using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class PaymentsAmountAdapter : BaseAdapter
    {
        private readonly IFinancialServices _financialServices;

        public PaymentsAmountAdapter(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        public override string Evaluate(Context context)
        {
            XText productXText = context.Element.Nodes().OfType<XText>().FirstOrDefault();
            if (productXText == null)
            {
                return "";
            }
            return _financialServices.GetRemainingPayments(productXText.Value).ToString();
        }
    }
}