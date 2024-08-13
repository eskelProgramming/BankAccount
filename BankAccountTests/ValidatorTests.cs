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
    public class ValidatorTests
    {
        [TestMethod()]
        [DataRow(0, 100, 0)]
        [DataRow(0, 100, 100)]
        [DataRow(0, 100, 50)]
        public void IsWithinRange_InclusiveRange_ReturnsTrue
                    (double min, double max, double test)
        {
            Assert.IsTrue(Validator.IsWithinRange(min, max, test));
        }

        [TestMethod]
        [DataRow(0, 100, -1)]
        [DataRow(0, 100, 101)]
        public void IsWithinRange_OutOfRangeValue_ReturnsFalse
                    (double min, double max, double test)
        {
            Assert.IsFalse(Validator.IsWithinRange(min, max, test));
        }
    }
}