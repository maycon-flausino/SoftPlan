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
        /// <param name="valorincial">valorinicial</param>
        /// <param name="meses">meses</param>

        [HttpGet("api/v1/calculajuros")]
        //GET: api/v1/calculajuros?valorinicial=100&meses=5
        public IActionResult Get(decimal valorinicial, int meses)
        {
            if (valorinicial > 0 && meses > 0)
            {
                return Ok(_repository.Calculator(valorinicial, meses, _configuration.GetValue<string>("InterestRateApi")).ToString("N2"));
            }
            return Redirect("/swagger/index.html");
        }

        /// <summary>
        /// Get the codification in the Github.
        /// </summary>
        /// <returns>The code.</returns>
        [HttpGet("api/v1/showmethecode")]
        public IActionResult Get()
        {
            return Ok(_configuration.GetValue<string>("Github"));
        }
    }
}