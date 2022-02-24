using System;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    /// <summary>
    /// Обрабатывает события, связанные с классом Account.
    /// </summary>
    public class AccountEventArgs
    {
        /// <summary>
        /// Содержит сообщение события.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Сумма, на которую изменится счет.
        /// </summary>
        public decimal Sum { get; private set; }

        public AccountEventArgs(string _mes, decimal _sum)
        {
            Message = _mes;
            Sum = _sum;
        }
    }
}
