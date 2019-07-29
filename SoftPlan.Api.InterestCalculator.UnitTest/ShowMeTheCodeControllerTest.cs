using Microsoft.Extensions.Configuration;
using SoftPlan.Api.InterestCalculator.Controllers;
using Xunit;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SoftPlan.Api.InterestCalculator.UnitTest
{
    public class ShowMeTheCodeControllerTest
    {
        private readonly ShowMeTheCodeController _constructor;

        public ShowMeTheCodeControllerTest()
        {
            IConfiguration configuration = GetConfigurationBuilder(Directory.GetCurrentDirectory());
            _constructor = new ShowMeTheCodeController(configuration);
        }

        [Fact]
        public void ShouldReturnGithubRepository()
        {    
            var actual = Assert.IsType<OkObjectResult>(_constructor.Get());
            var expected = "https://github.com/maycon-flausino/Softplan";
            Assert.Equal(expected, actual.Value);
        }

        public static IConfiguration GetConfigurationBuilder(string pathConfigurationBuilder)
        {
            try
            {
                return new ConfigurationBuilder()                        
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json")
                       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                       .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
                       .AddEnvironmentVariables()
                       .Build();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
