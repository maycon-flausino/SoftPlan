using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SoftPlan.Api.InterestCalculator.Controllers
{
    public class ShowMeTheCodeController : Controller
    {
        private readonly IConfiguration _configuration;

        public ShowMeTheCodeController(IConfiguration configuration)
        {
            _configuration = configuration;
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