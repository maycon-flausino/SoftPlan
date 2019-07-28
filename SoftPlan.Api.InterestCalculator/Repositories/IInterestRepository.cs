using System.Collections.Generic;

namespace SoftPlan.Api.InterestCalculator.Repositories
{
    public interface IInterestRepository
    {
        double GetInterestRate(string urlApi);
        decimal Calculator(decimal initialValue, int month, string urlApi );
    }
}
