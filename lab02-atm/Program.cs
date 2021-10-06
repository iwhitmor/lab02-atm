using System;

namespace lab02_atm
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {
            WriteWelcome();

            int[] array = new int[4];

            for (int i = 0; i < array.Length; i++)
            {

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
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-4");
                }
            }
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Your Most Trusted Bank");
            Console.WriteLine();
        }

        static int PromptForAction()
        {
            try
            {
                Console.WriteLine("What would you like to do today (1/2/3/4)?");
                Console.WriteLine("1. Deposit money to your account");
                Console.WriteLine("2. Withdraw money from your account");
                Console.WriteLine("3. Check your balance");
                Console.WriteLine("4. Exit");

                Console.Write("Your Choice: ");
                string input = Console.ReadLine();

                int userInput = Convert.ToInt32(input);

                return userInput;
            }

            catch (FormatException)
            {
                Console.WriteLine("You must enter a number");

                return 0;
            }
            
        }

        static void PromptAndDeposit()
        {
            Console.WriteLine("How much money would you like to deposit today?");
            Console.Write("Deposit Amount: ");
            string input = Console.ReadLine();
            decimal userInput = Convert.ToDecimal(input);
            account.AddToBalance(userInput);
            decimal balance = account.GetBalance();
            Console.WriteLine($"Deposit successful: {userInput}");
            Console.WriteLine($"You now have a balance of ${balance}");
        }

        static void PromptAndWithdraw()
        {
            Console.WriteLine("How much money would you like to withdraw today?");
            Console.Write("Withdraw Amount: ");
            string input = Console.ReadLine();
            decimal userInput = Convert.ToDecimal(input);
            account.WithdrawFromBalance(userInput);

            decimal balance = account.GetBalance();
            Console.WriteLine($"Withdraw successful: {userInput}");
            Console.WriteLine($"You now have a balance of ${balance}");
        }

        static void ViewBalance()
        {
            decimal balance = account.GetBalance();
            Console.WriteLine($"Here is your current balance: ${balance}");
        }
    }
}
