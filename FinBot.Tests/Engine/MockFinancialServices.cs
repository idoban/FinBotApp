using System;
using FinBot.Engine;

namespace FinBot.Tests.Engine
{
    public class MockFinancialServices : IFinancialServices
    {
        public decimal GetUpcomingCreditCardChargeAmount()
        {
            return 100;
        }

        public decimal GetTotalBalance()
        {
            return 200;
        }

        public DateTime GetUpcomingCreditCardChargeDate()
        {
            return new DateTime(2017, 6, 10);
        }

        public bool PayslipReceived()
        {
            return true;
        }

        public int GetRemainingPayments(string productName)
        {
            return 6;
        }

        public decimal GetCreditCardBalance()
        {
            return 20000;
        }

        public decimal GetAnnualSalary()
        {
            return 170000;
        }

        public decimal GetMonthlySalary()
        {
            return 10000;
        }
    }
}