using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class ReviewReply
    {
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
