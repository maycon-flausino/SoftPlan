using SoftPlan.Api.InterestCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Api.InterestCalculator.Repositories
{
    public interface IInterestRepository
    {
        IEnumerable<InterestEntity> GetInterest();
        decimal Calculator(string valorinicial, string meses);
    }
}
