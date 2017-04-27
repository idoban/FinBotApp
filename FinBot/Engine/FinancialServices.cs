using System;
namespace FinBot.Engine
{
    public interface IFinancialServices
    {
        decimal GetUpcomingCreditCardChargeAmount();
        decimal GetTotalBalance();
        DateTime GetUpcomingCreditCardChargeDate();
        bool PayslipReceived();
        int GetRemainingPayments(string productName);
        decimal GetCreditCardBalance();
        decimal GetAnnualSalary();
        decimal GetMonthlySalary();
        decimal GetMonthlyExpenses();
    }

    public class FinancialServices : IFinancialServices
    {
        private readonly Random _random = new Random();

        public decimal GetUpcomingCreditCardChargeAmount()
        {
            return _random.Next(10000, 50000);
        }

        public decimal GetTotalBalance()
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

        public decimal GetCreditCardBalance()
        {
            return _random.Next(1, 10) * 1000;
        }

        public decimal GetAnnualSalary()
        {
            return _random.Next(10, 20) * 10000;
        }

        public decimal GetMonthlySalary()
        {
            return _random.Next(10, 20) * 1000;
        }

        public decimal GetMonthlyExpenses()
        {
            return _random.Next(10, 20) * 9000;
        }
    }
}