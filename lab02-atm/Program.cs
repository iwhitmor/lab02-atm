﻿using System;

namespace lab02_atm
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {

            WriteWelcome();
            PromptForAction();
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
