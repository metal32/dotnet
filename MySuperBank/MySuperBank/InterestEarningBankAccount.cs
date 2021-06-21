﻿using System;
namespace MySuperBank
{
    public class InterestEarningBankAccount : BankAccount
    {
        public InterestEarningBankAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}