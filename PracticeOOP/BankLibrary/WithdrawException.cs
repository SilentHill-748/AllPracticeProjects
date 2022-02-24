using System;

namespace BankLibrary
{
    class WithdrawException : Exception
    {
        public WithdrawException(string message) : base(message) { }
    }
}
