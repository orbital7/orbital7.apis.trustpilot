using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class BusinessUnitSearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("name")]
        public BusinessUnitName Name { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
