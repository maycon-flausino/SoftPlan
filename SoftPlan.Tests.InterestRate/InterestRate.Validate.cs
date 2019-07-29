using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SoftPlan.Tests.InterestRate
{
   public class InterestRate
    {
       
        [Fact]
        public void ReturnValue()
        {
            //var result = _primeService.IsPrime(1);

            //Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void Calculator()
        {
            Services.Bussiness.Calculator.CalculateInterest(100, 5, 0.01);
        }
    }
}
