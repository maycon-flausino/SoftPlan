using System.Collections.Generic;
using SoftPlan.Api.InterestRate.Models;

namespace SoftPlan.Api.InterestRate.Repositories
{
    public class InterestRatesRepository : IInterestRatesRepository
    {
        private readonly List<InterestRatesEntity> _repository;

        public InterestRatesRepository()
        {
            _repository = new List<InterestRatesEntity> { new InterestRatesEntity { } };
        }

        public IEnumerable<InterestRatesEntity> GetInterestRates()
        {
            return _repository;
        }
    }
}
