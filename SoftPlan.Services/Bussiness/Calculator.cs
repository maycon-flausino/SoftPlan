using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPlan.Services.Bussiness
{
    public static class Calculator
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static decimal CalculateInterest(decimal initialValue, int moth, double interestRate)
        {
            try
            {
                var interestRateCalculed = (Math.Pow(1 + interestRate, moth)) * Convert.ToDouble(initialValue);
                var resultWithTruncate = Convert.ToDecimal(Math.Truncate(100 * interestRateCalculed) / 100);
                return resultWithTruncate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static decimal CalculateInterest(decimal v1, int v2, object rateReturn)
        {
            throw new NotImplementedException();
        }
    }
}
