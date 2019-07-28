using System;
using System.Net;

namespace SoftPlan.Services.Utils
{
    public class Utilities
    {
        public static HttpWebResponse GetApi(string urlApi)
        {
            try
            {
                //string urlApi = string.Format("https://localhost:44323/api/v1/taxajuros");
                WebRequest requestObjGet = WebRequest.Create(urlApi);
                requestObjGet.Method = "GET";
                return (HttpWebResponse)requestObjGet.GetResponse();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
