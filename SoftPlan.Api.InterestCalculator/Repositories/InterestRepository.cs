using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (string.IsNullOrEmpty(urlApi))
                return 0;
            try
            {
                return Services.Bussiness.Calculator.CalculateInterest(initialValue, moth, Convert.ToDecimal(GetInterestRate(urlApi)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
                
        public decimal GetInterestRate(string urlApi)
        {

            try
            {
                HttpWebResponse responseObjGet = null;
                responseObjGet = Services.Utils.Utilities.GetApi(urlApi);

                if (responseObjGet == null)
                    return 0;

                string jsonResult;

                using (Stream stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    jsonResult = sr.ReadToEnd();
                    return Convert.ToDecimal(JsonConvert.DeserializeObject<IEnumerable<InterestRepository>>(jsonResult).FirstOrDefault().InterestRate);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
