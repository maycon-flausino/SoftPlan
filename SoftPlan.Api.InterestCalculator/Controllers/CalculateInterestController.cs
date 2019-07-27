using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SoftPlan.Api.InterestCalculator.Repositories;

namespace SoftPlan.Api.InterestCalculator.Controllers
{
    public class CalculateInterestController : Controller
    {
        private readonly IInterestRepository _repository;
        private readonly IConfiguration _configuration;

        public CalculateInterestController(IInterestRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        /// <summary>
        /// Get calculate interest.
        /// </summary>
        /// <returns>Calculate Interest</returns>
        //GET: api/v1/calculajuros?valorinicial=100&meses=5       
        [HttpGet("api/v1/calculajuros")]
        public IActionResult Get(decimal valorinicial, int meses)
        {
            return Ok(_repository.Calculator(valorinicial, meses));
        }

        /// <summary>
        /// Get the codification in the Github.
        /// </summary>
        /// <returns>The code.</returns>
        [HttpGet("api/v1/showmethecode")]
        public ActionResult Get()
        {
            return Ok(_configuration.GetValue<string>("Github"));

        }


    }
}