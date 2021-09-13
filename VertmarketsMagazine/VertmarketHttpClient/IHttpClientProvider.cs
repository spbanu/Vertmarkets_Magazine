using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace VertmarketHttpClient
{
    public interface IHttpClientProvider
    {
        HttpClient GetHttpClient(DelegatingHandler[] delegatingHandlers, HttpMessageHandler httpMessageHandler);
    }
}
