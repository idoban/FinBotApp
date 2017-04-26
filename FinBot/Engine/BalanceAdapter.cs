using System;
using Syn.Bot.Siml;

namespace FinBot.Engine
{
    public class BalanceAdapter : BaseAdapter
    {
        public override string Evaluate(Context context)
        {
            string accountNumber;
            if (!context.User.Vars.TryGetValue("account", out accountNumber))
            {
                return "Please tell me your bank account number";
            }
            if (!context.User.Vars.TryGetValue("password", out accountNumber))
            {
                return "Please tell me your bank account passowrd";
            }
            return string.Format("Your balance is ${0}", new Random().Next(10000, 50000));
        }
    }
}