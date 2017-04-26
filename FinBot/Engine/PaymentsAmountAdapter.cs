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
                return "What product do you want to know how many payments left?";
            }
            var remainingPayments = _financialServices.GetRemainingPayments(productXText.Value);

            return string.Format("You have {0} remaining payments for {1}", remainingPayments, productXText.Value);
        }
    }
}