using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftPlan.Api.InterestCalculator.Repositories;

namespace SoftPlan.Api.InterestCalculator.Controllers
{
    public class CalculateInterestController : Controller
    {
        private readonly IInterestRepository _repository;

        public CalculateInterestController(IInterestRepository repository)
        {
            _repository = repository;
        }

        //GET: api/calculajuros?valorinicial=100&meses=5       
        [HttpGet("api/calculajuros")]
        public IActionResult Get(string valorinicial, string meses)
        {            
            return Ok(_repository.Calculator(valorinicial, meses));
        }
    }
}