using System;

namespace BankLibrary
{
    public interface IAccount
    {
        /// <summary>
        /// Выполняет пополнение средств на счета.
        /// </summary>
        /// <param name="sum"></param>
        void Put(decimal sum);

        /// <summary>
        /// Выполняет снятие средств со счетов.
        /// </summary>
        /// <param name="sum"></param>
        decimal Withdraw(decimal sum);
    }
}
