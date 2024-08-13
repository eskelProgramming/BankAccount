using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public static class Validator
    {
        public static bool IsWithinRange(double minValue, double maxValue, double valueToTest)
        {
           return valueToTest >= minValue && valueToTest <= maxValue;
        }
    }
}
