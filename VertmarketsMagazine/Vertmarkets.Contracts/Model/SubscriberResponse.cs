using System;
using System.Collections.Generic;
using System.Text;

namespace Vertmarkets.Contracts.Model
{
    public class SubscriberResponse
    {
        public List<Subscriber> Data { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
    public class Subscriber
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> MagazineIds { get; set; }
    }
}
