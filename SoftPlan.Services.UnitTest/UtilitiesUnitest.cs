using SoftPlan.Services.Utils;
using System;
using System.Net;
using Xunit;

namespace SoftPlan.Services.UnitTest
{
    public class UtilitiesUnitest
    {
        [Fact]
        public void UtilitiesGetApiWhenUrlApiIsTrue()
        {
            var urlApi = "http://maycon2019-001-site1.htempurl.com/api/v1/taxajuros";
            WebRequest requestObjGet = WebRequest.Create(urlApi);
            requestObjGet.Method = "GET";
            var actual = (HttpWebResponse)requestObjGet.GetResponse();

            var expected = Utilities.GetApi(urlApi);

            Assert.Equal(expected.ResponseUri, actual.ResponseUri); ;
        }

        //[Fact]
        //public void UtilitiesGetApiWhenUrlApiIsNull()
        //{
        //    var urlApi = "";
        //    var actual = "http://maycon2019-001-site1.htempurl.com/api/v1/taxajuros";
        //    var request = WebRequest.Create(urlApi) as HttpWebRequest;
        //    if (request == null) "";
        //    else
        //    {
        //        WebRequest requestObjGet = WebRequest.Create(urlApi);
        //        requestObjGet.Method = "GET";
        //        var response = (HttpWebResponse)request.GetResponse();

        //    }
                       
        //    var expected = Utilities.GetApi(urlApi);

        //    Assert.Equal(expected.ResponseUri, actual.ResponseUrl); ;
        //}

    }
}
