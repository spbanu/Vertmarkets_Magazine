using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace VertmarketHttpClient
{
    public class HttpClientProvider : IHttpClientProvider
    {
        public HttpClient GetHttpClient(DelegatingHandler[] delegatingHandlers, HttpMessageHandler httpMessageHandler)
        {
            if (httpMessageHandler == null)
            {
                return HttpClientFactory.Create(delegatingHandlers);
            }

            return HttpClientFactory.Create(httpMessageHandler, delegatingHandlers);
        }
    }
}
