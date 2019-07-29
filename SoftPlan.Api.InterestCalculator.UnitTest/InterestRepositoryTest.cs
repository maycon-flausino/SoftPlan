using SoftPlan.Api.InterestCalculator.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SoftPlan.Api.InterestCalculator.UnitTest
{
    public class InterestRepositoryTest
    {
        private InterestRepository _repository;

        public InterestRepositoryTest()
        {
            _repository = new InterestRepository();
        }

        [Fact]
        public void GetInterestRateIfUrlIsNull()
        {
            var expected = 0;
            var actual = _repository.Calculator(100, 5, "");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetInterestRateIfUrlIsFalse()
        {
            double expected = 0.01;
            double actual = _repository.GetInterestRate("http://maycon2019-001-site1.htempurl.com/api/v1/taxajuros");            
            Assert.Equal(expected, actual);
        }       

    }
}
