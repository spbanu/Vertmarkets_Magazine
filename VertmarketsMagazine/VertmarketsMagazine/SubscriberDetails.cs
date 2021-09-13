using System;
using System.Collections.Generic;
using System.Text;

namespace VertmarketsMagazine
{
    public class SubscriberDetails
    {
        public string Category { get; set; }
        public string SubscriberId { get; set; }

        public SubscriberDetails(string category, string subsciberId)
        {
            Category = category;
            SubscriberId = subsciberId;
        }
    }
    public class ObjectComparer : IEqualityComparer<SubscriberDetails>
    {
        public bool Equals(SubscriberDetails x, SubscriberDetails y)
        {
            return x.Category == y.Category && x.SubscriberId == y.SubscriberId;
        }

        public int GetHashCode(SubscriberDetails obj)
        {
            if (obj is null) return 0;
            int hashCat = obj.Category == null ? 0 : obj.Category.GetHashCode();
            int hashSubId = obj.SubscriberId == null ? 0 : obj.SubscriberId.GetHashCode();
            return hashCat ^ hashSubId;
        }
    }
}
