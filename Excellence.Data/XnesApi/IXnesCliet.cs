using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Excellence.Data.XnesApi
{
    public interface IXnesApi
    {
        //https://www.xnes.co.il/ClosedSystemMiddlewareApi/api/generalinformation
        [Get("/ClosedSystemMiddlewareApi/api/generalinformation")]
        Task<XnesResponse> GetGenerealInfo();
    }

    public static class XnesClientFactory
    {
        private const string EndPoint = "https://www.xnes.co.il";
        public static IXnesApi Create()
        {
            return RestService.For<IXnesApi>(EndPoint);
        }
    }
}
