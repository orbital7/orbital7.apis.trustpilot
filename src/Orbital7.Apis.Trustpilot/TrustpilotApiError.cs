using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class TrustpilotApiError
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("correlationId")]
        public Guid CorrelationId { get; set; }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
