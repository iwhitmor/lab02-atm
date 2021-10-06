using System;

namespace lab02_atm
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {

            WriteWelcome();
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Your Trusted Bank");
        }

        static int PromptForAction()
        {
            return 1;
        }

        static void PromptAndDeposit()
        {

        }

        static void PromptAndWithdraw()
        {

        }

        static void ViewBalance()
        {

        }
    }
}
