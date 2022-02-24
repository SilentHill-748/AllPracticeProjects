﻿using System;

namespace BankLibrary
{
    public class DepositAccount : Account
    {
        public DepositAccount(decimal sum, int percentage) : base(sum, percentage) { }

        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Открыт новый депозитный счет! ID: {this.ID}", this.Sum));
        }

        public override void Put(decimal sum)
        {
            if(_days % 30 == 0)
            {
                base.Put(sum);
            }
            base.OnAdded(new AccountEventArgs($"Счет можно пополнить только после 30-тидневного периода!", 0));
        }

        public override decimal Withdraw(decimal sum)
        {
            if(_days % 30 == 0)
            {
                return base.Withdraw(sum);
            }
            else
            {
                base.OnWithdrawed(new AccountEventArgs("Снять со счета можно только после 30-дневного периода!", 0));
                return 0;
            }
        }

        protected internal override void Calculate()
        {
            if (_days % 30 == 0)
            {
                base.Calculate();
            }
        }
    }
}
