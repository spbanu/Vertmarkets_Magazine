using System;
using System.Collections.Generic;
using System.Text;
using Vertmarkets.Contracts;

namespace Vertmarkets.Contracts.Model
{
    public class ConnectionInfo : IConnectionInfo
    {
        public string HostUrl { get; set; }
        public string HttpVerb { get; set; }
        public int TimeOutInSeconds { get; set; }
    }
}
