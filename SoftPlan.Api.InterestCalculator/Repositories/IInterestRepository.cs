using System.Collections.Generic;

namespace SoftPlan.Api.InterestCalculator.Repositories
{
    public interface IInterestRepository
    {
        decimal GetInterestRate(string urlApi);
        decimal Calculator(decimal initialValue, int month, string urlApi );
    }
}
