using SoftPlan.Services.Bussiness;
using Xunit;

namespace SoftPlan.Services.UnitTest
{
    public class CalculatorUnitTest
    {       

        /// <summary>
        /// Return when interest rate is alteraded.
        /// </summary>
        [Theory]
        [InlineData(100, 5, .01, 105.10)]
        [InlineData(100, 5, .02, 110.40)]
        [InlineData(100, 5, .03, 115.92)]
        [InlineData(100, 5, .04, 121.66)]
        [InlineData(100, 5, .05, 127.62)]
        [InlineData(100, 5, .06, 133.82)]
        public void CalculatorResultWhenInterestRateAlteraded(decimal initialValue, int month, double interestRate, decimal result)
        {
            var expected = result;
            var actual = Calculator.CalculateInterest(initialValue, month, interestRate);

            Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Return inicial value when month is zero.
        /// </summary>
        [Fact]
        public void CalculatorInitialValueWhenMothValueIsZero()
        {
            var initialValue = 100;
            var month = 0;
            var interestRate = 0.01;
            var expected = initialValue;
            var actual = Calculator.CalculateInterest(initialValue, month, interestRate);

            Assert.Equal(expected, actual);
        }


        /// <summary>
        /// Return initial value when interest rate is zero.
        /// </summary>
        [Fact]
        public void CalculatorInitialValueWhenInterestRateValueIsZero()
        {
            var initialValue = 100;
            var month = 5;
            var interestRate = 0;
            var expected = initialValue;
            var actual = Calculator.CalculateInterest(initialValue, month, interestRate);            

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Return zero when initial value and month are zero.
        /// </summary>
        [Fact]
        public void CalculatorZeroWhenInitialValueAndMonthIsZero()
        {
            var initialValue = 0;
            var month = 0;
            var interestRate = 0.01;
            var expected = 0;
            var actual = Calculator.CalculateInterest(initialValue, month, interestRate);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatorZeroWhenInitialValueIsZero()
        {
            var initialValue = 0;
            var month = 5;
            var interestRate = 0.01;
            var expected = 0;
            var actual = Calculator.CalculateInterest(initialValue, month, interestRate);

            Assert.Equal(expected, actual);
        }

    }
}
