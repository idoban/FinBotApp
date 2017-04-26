using System;

namespace FinBot.Engine
{
    public interface IFinancialServices
    {
        decimal GetUpcomingCreditCardChargeDate();
    }

    public class FinancialServices : IFinancialServices
    {
        public decimal GetUpcomingCreditCardChargeDate()
        {
            return new Random().Next(10000, 50000);
        }
    }
}