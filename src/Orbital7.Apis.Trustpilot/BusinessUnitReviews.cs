using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class BusinessUnitReviews
    {
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("reviews")]
        public List<BusinessUnitReview> Reviews { get; set; }

        public int page { get; set; }

        public int perPage { get; set; }

        public override string ToString()
        {
            return this.Reviews.Count.ToString();
        }
    }
}
