using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;


namespace SoftPlan.Api.InterestCalculator.Repositories
{
    public class InterestRepository : IInterestRepository
    {
        [JsonProperty(PropertyName = "interest")]
        public string InterestRate { get; set; }
              

        public decimal Calculator(decimal initialValue, int moth, string urlApi)
        {
           return Services.Bussiness.Calculator.CalculateInterest(initialValue, moth, GetInterestRate(urlApi));
        }
                
        public double GetInterestRate(string urlApi)
        {
            try
            {
                HttpWebResponse responseObjGet = null;
                responseObjGet = Services.Utils.Utilities.GetApi(urlApi);

                string jsonResult;

                using (Stream stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    jsonResult = sr.ReadToEnd();
                    return Convert.ToDouble(JsonConvert.DeserializeObject<IEnumerable<InterestRepository>>(jsonResult).FirstOrDefault().InterestRate);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
