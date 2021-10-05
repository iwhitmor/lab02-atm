using System;
using Xunit;

namespace lab02_atm.tests
{
    public class BankAccountTests
    {
        [Fact]
        public void Get_Balance_Gets_Balance()
        {

            //Arrange
            BankAccount bank = new BankAccount();

            //Act
            decimal balance = bank.GetBalance();

            //Assert
            Assert.Equal(0, balance);
        }

        [Fact]
        public void Add_Money_To_Balance()
        {

            //Arrange
            BankAccount bank = new BankAccount();

            //Act
            bank.AddToBalance(25);

            //Assert
            decimal balance = bank.GetBalance();
            Assert.Equal(25, balance);
        }

        [Fact]
        public void Withdraw_Money_From_Balance()
        {

            //Arrange
            BankAccount bank = new BankAccount();
            bank.AddToBalance(30);

            //Act
            bank.WithdrawFromBalance(25);

            //Assert
            decimal balance = bank.GetBalance();
            Assert.Equal(5, balance);
        }

        [Fact]
        public void Deposit_Throws_For_Negative_Amount()
        {

            //Arrange
            BankAccount bank = new BankAccount();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                //Act
                bank.AddToBalance(-20);

            });
        }

        [Fact]
        public void Withdraw_Throws_If_Money_No_Available()
        {

            //Arrange
            BankAccount bank = new BankAccount();
            bank.AddToBalance(20);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                //Act
                bank.WithdrawFromBalance(25);
            });
        }

        [Fact]
        public void Withdraw_Throws_For_Negative_Amount()
        {
            //Arrange
            BankAccount bank = new BankAccount();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                //Act
                bank.WithdrawFromBalance(-1);
            });
        }
     
    }
}
