using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class BusinessUnitName
    {
        [JsonProperty("identifying")]
        public string Identifying { get; set; }

        [JsonProperty("referring")]
        public List<string> Referring { get; set; }

        public override string ToString()
        {
            return this.Identifying;
        }
    }
}
