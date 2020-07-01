using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class Consumer
    {
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayLocation")]
        public string DisplayLocation { get; set; }

        [JsonProperty("numberOfReviews")]
        public int NumberOfReviews { get; set; }

        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
