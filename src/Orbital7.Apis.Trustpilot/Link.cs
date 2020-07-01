using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class Link
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        public override string ToString()
        {
            return this.Href;
        }
    }
}
