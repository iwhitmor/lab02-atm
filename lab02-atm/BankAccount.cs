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
            balance += amountToDeposit;
        }

        public void WithdrawFromBalance(decimal amountToWithdraw)
        {
            balance -= amountToWithdraw;
        }
    }
}
