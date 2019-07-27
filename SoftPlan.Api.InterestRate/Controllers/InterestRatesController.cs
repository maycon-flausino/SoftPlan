using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftPlan.Api.InterestRate.Repositories;

namespace SoftPlan.Api.InterestRate.Controllers
{
      
    public class InterestRatesController : Controller
    {
        private readonly IInterestRatesRepository _repositorio;

        public InterestRatesController(IInterestRatesRepository repositorio)
        {
            _repositorio = repositorio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET api/Taxa de Juros
        [HttpGet("api/v1/taxajuros")]
        public IActionResult Get()
        {
            return Ok(_repositorio.GetInterestRates());
        }
    }
}