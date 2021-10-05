using System;
namespace lab02_atm
{
    public class BankAccount
    {
        private decimal balance = 0;

        public decimal GetBalance()
        {
            return balance;
        }

        public void AddToBalance(decimal amountToDeposit)
        {
            if (amountToDeposit < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else balance += amountToDeposit;
        }

        public void WithdrawFromBalance(decimal amountToWithdraw)
        {
            if (amountToWithdraw > balance)
            {
                throw new ArgumentOutOfRangeException();
            }

            else balance -= amountToWithdraw;
        }
    }
}
