using System;

namespace lab02_atm
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {

            WriteWelcome();

            int action = PromptForAction();

            if (action == 1)
            {
                PromptAndDeposit();
            }
            else if (action == 2)
            {
                PromptAndWithdraw();
            }
            else if (action == 3)
            {
                ViewBalance();
            }
            else if (action == 4)
            {
                Exit();
            }
           
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Your Trusted Bank");
        }

        static int PromptForAction()
        {
            Console.WriteLine("What would you like to do today (1/2/3/4)?");
            Console.WriteLine("1. Deposit money to your account");
            Console.WriteLine("2. Withdraw money from your account");
            Console.WriteLine("3. Check your balance");
            Console.WriteLine("4. Exit");
            string input = Console.ReadLine();

            int userInput = Convert.ToInt32(input);

            return userInput;
        }

        static void PromptAndDeposit()
        {
            Console.WriteLine("How much money would you like to deposit today?");
        }

        static void PromptAndWithdraw()
        {
            Console.WriteLine("How much money would you like to withdraw today?");
        }

        static void ViewBalance()
        {
            Console.WriteLine("Here is your current balance: ");
        }
        static void Exit()
        {
            Console.WriteLine("Thank you, and have a great day!");
        }
    }
}
