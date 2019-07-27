using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftPlan.Api.InterestCalculator.Models;

namespace SoftPlan.Api.InterestCalculator.Repositories
{
    public class InterestRepository : IInterestRepository
    {
        private readonly List<InterestEntity> _repository;

        public InterestRepository()
        {
            _repository = new List<InterestEntity> { new InterestEntity { } };
        }

        public decimal Calculator(decimal valorinicial, int meses)
        {
           return Services.Bussiness.Calculator.CalculateInterest(valorinicial, meses, rateReturn());
        }

        private double rateReturn()
        {
            return 0.01;
        }

        public IEnumerable<InterestEntity> GetInterest()
        {
            return _repository;
        }
                
    }
}
