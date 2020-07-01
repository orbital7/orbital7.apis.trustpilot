using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class TrustpilotApiException
        : Exception
    {
        public TrustpilotApiError Error { get; set; }

        public TrustpilotApiException(
            TrustpilotApiError error)
            : base(error.Message)
        {
            this.Error = error;
        }
    }
}
