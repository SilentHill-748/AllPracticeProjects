using System;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        // Событие, возникающее при выводе средств.
        protected internal event AccountStateHandler Withdrawed;

        // Событие, возникающее при пополнении средств.
        protected internal event AccountStateHandler Added;

        // Событие, возникающее при открытии счета.
        protected internal event AccountStateHandler Opened;

        // Событие, возникающее при закрытии счета.
        protected internal event AccountStateHandler Closed;

        // Событие, возникающее при расчете процентов.
        protected internal event AccountStateHandler Calculated;


        static int counter = 0;
        protected int _days = 0; // Время с момента открытия счета.

        public int ID { get; private set; }         // Номер счета.
        public int Percentage { get; private set; } // Процент начислений.
        public decimal Sum { get; private set; }    // Текущая сумма  на счету.

        public Account(decimal sum, int percentage)
        {
            Sum = sum;
            Percentage = percentage;
            ID = ++counter;
        }

        // Вызов событий.
        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if(e != null)
            {
                handler?.Invoke(this, e);
            }
        }

        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }

        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }

        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }

        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }

        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs("На счет поступило " + sum, sum));
        }

        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;

            try
            {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs($"Со счета {ID} снято {sum}", sum));
            }
            catch(WithdrawException ex) when(Sum < 0)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Открывает новый счет.
        /// </summary>
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"Счет с номером {ID} создан.", Sum));
        }

        /// <summary>
        /// Закрывает счет.
        /// </summary>
        protected internal void Close()
        {
            OnClosed(new AccountEventArgs($"Счет {ID} успешно закрыт! Итоговая сумма: {Sum}", Sum));
        }

        protected internal void IncrementDays()
        {
            _days++;
        }

        /// <summary>
        /// Начисляет проценты.
        /// </summary>
        protected internal virtual void Calculate()
        {
            decimal increment = Sum * Percentage / 100;
            Sum += increment;
            OnCalculated(new AccountEventArgs($"Процент начислен на счет {ID}. Начислено {increment}. Итого на счету: {Sum}", Sum));
        }
    }
}
