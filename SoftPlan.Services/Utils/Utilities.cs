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
                //if (CkeckUrl(urlApi))
                //{
                    WebRequest requestObjGet = WebRequest.Create(urlApi);
                    requestObjGet.Method = "GET";
                    return (HttpWebResponse)requestObjGet.GetResponse();
                //}
                //return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool CkeckUrl(string urlApi)
        {
            if (urlApi.Equals("http://maycon2019-001-site1.htempurl.com/api/v1/taxajuros"))
                return true;
            else
                return false;
        }
    }
}
