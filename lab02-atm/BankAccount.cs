using System;
using System.IO;

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

            else
            {
                balance += amountToDeposit;
                WriteToLog(amountToDeposit);
            }
        }

        public void WithdrawFromBalance(decimal amountToWithdraw)
        {
            if ((amountToWithdraw > balance) || (amountToWithdraw < 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            else balance -= amountToWithdraw;
        }

        private static void WriteToLog(decimal amount)
        {
            string logMessage = $"{DateTime.Today:yyyy-MM-dd}: {amount}\n";
            File.AppendAllText("transaction-log.txt", logMessage);
        }

        public string[] GetLog()
        {
            string[] transactions = File.ReadAllLines("transaction-log.txt");

            return transactions;
        }

        public void ClearLog()
        {
            File.WriteAllText("transaciton-log.txt", "");
        }
    }
}
