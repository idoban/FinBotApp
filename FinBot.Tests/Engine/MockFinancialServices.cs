using FinBot.Engine;

namespace FinBot.Tests.Engine
{
    public class MockFinancialServices : IFinancialServices
    {
        public decimal GetUpcomingCreditCardChargeDate()
        {
            return 100;
        }
    }
}