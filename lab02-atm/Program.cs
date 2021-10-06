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

        static void PromptForAction()
        {

        }
    }
}
