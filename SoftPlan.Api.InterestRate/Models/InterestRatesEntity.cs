using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Api.InterestRate.Models
{
    public class InterestRatesEntity
    {
        private const string RATE = "0,01";

        public string Interest { get; }

        public InterestRatesEntity()
        {
            Interest = RATE;
        }
    }
}
