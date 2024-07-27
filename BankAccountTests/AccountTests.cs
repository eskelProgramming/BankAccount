using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_APositiveAmount_AddToBalance()
        {
            Account acc = new("j. Doe");
            acc.Deposit(100);

            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod]
        public void Deposit_APositiveAmount_ReturnsUpdatedBalance()
        {
            // AAA Arrange Act Assert
            // Arrange
            Account acc = new("J. Doe");
            double depositAmt = 100;
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmt);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }
    }
}