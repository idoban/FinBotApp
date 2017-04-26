using System;
namespace FinBot.Engine
{
    public interface IFinancialServices
    {
        decimal GetUpcomingCreditCardChargeAmount();
        decimal GetBalance();
        DateTime GetUpcomingCreditCardChargeDate();
    }

    public class FinancialServices : IFinancialServices
    {
        public decimal GetUpcomingCreditCardChargeAmount()
        {
            return new Random().Next(10000, 50000);
        }

        public decimal GetBalance()
        {
            return new Random().Next(10000, 50000);
        }

        public DateTime GetUpcomingCreditCardChargeDate()
        {
            return new DateTime(2017, 6, 1);
        }
    }
}