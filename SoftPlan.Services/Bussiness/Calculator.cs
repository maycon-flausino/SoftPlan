using System;

namespace SoftPlan.Services.Bussiness
{
    public static class Calculator
    {

        public static decimal CalculateInterest(decimal initialValue, int month, decimal interestRate)
        {
            try
            {
                var interestRateCalculed = Math.Pow(Convert.ToDouble(1 + interestRate), month) * Convert.ToDouble(initialValue);
                var resultWithTruncate = Convert.ToDecimal(Math.Truncate(100 * interestRateCalculed) / 100);
                return resultWithTruncate;
           }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}