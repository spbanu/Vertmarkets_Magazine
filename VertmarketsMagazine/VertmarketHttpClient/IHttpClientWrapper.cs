using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Vertmarkets.Contracts;

namespace VertmarketHttpClient
{
    public interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> PostContent(IConnectionInfo connectionInfo, string bodyContent, string contentType = "application/json");
    }
}
