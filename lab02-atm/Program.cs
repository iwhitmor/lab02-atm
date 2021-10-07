using System;

namespace lab02_atm
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {
            account.ClearLog();

            WriteWelcome();

            while (true)
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
                    DisplayTransactionLog();
                }
                else if (action == 5)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-5");
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
                Console.WriteLine("4. Check your transaction log");
                Console.WriteLine("5. Exit");
                

                Console.Write("Your Choice: ");
                string input = Console.ReadLine();

                int userInput = Convert.ToInt32(input);

                return userInput;
            }

            catch (FormatException)
            {
                Console.WriteLine("You must enter a number. Please try again.");

                return 0;
            }   
        }

        static void PromptAndDeposit()
        {
            try
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
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your deposit amount was a negative number, please try again.");
            }
        }

        static void PromptAndWithdraw()
        {
            try
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

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered a negative number or did not have enough money in your account, please try again.");
            }
        }

        static void ViewBalance()
        {
            decimal balance = account.GetBalance();
            Console.WriteLine($"Here is your current balance: ${balance}");
        }

        static void DisplayTransactionLog()
        {
            string[] transactionLog = account.GetLog();
            for (int i = 0; i < transactionLog.Length; i++)
            {
                Console.WriteLine(transactionLog[i]);

            }
        }
    }
}
