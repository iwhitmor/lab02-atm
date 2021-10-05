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
    }
}
