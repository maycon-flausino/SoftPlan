using SoftPlan.Api.InterestRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Api.InterestRate.Repositories
{
    public interface IInterestRatesRepository
    {
        IEnumerable<InterestRatesEntity> GetInterestRates();
    }
}
