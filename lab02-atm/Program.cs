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
           
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Your Trusted Bank");
        }

        static int PromptForAction()
        {
            Console.WriteLine("What would you like to do today (1/2/3/4)?");
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
    }
}
