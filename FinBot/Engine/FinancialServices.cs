using System;
namespace FinBot.Engine
{
    public interface IFinancialServices
    {
        decimal GetUpcomingCreditCardChargeAmount();
        decimal GetBalance();
        DateTime GetUpcomingCreditCardChargeDate();
        bool PayslipReceived();
        int GetRemainingPayments(string productName);
    }

    public class FinancialServices : IFinancialServices
    {
        private readonly Random _random = new Random();

        public decimal GetUpcomingCreditCardChargeAmount()
        {
            return _random.Next(10000, 50000);
        }

        public decimal GetBalance()
        {
            return _random.Next(10000, 50000);
        }

        public DateTime GetUpcomingCreditCardChargeDate()
        {
            return new DateTime(2017, 6, 1);
        }

        public bool PayslipReceived()
        {
            return _random.NextDouble() > 0.5;
        }

        public int GetRemainingPayments(string productName)
        {
            return _random.Next(1, 12);
        }
    }
}