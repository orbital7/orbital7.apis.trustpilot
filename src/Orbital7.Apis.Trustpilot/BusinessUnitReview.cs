using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class BusinessUnitReview
    {
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("consumer")]
        public Consumer Consumer { get; set; }

        [JsonProperty("businessUnit")]
        public ReviewBusinessUnit BusinessUnit { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("stars")]
        public double Stars { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("companyReply")]
        public ReviewReply CompanyReply { get; set; }

        [JsonProperty("isVerified")]
        public bool? IsVerified { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("numberOfLikes")]
        public int NumberOfLikes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reportData")]
        public ReviewReportData ReportData { get; set; }

        [JsonProperty("complianceLabels")]
        public List<string> ComplianceLabels { get; set; }

        [JsonProperty("countsTowardsTrustScore")]
        public bool? CountsTowardsTrustScore { get; set; }

        [JsonProperty("countsTowardsLocationTrustScore")]
        public bool? CountsTowardsLocationTrustScore { get; set; }

        [JsonProperty("invitation")]
        public ReviewInvitation Invitation { get; set; }

        public override string ToString()
        {
            return this.Title;
        }

        public class ReviewBusinessUnit
        {
            [JsonProperty("links")]
            public List<Link> Links { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("identifyingName")]
            public string IdentifyingName { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }

            public override string ToString()
            {
                return this.DisplayName;
            }
        }

        public class ReviewReportData
        {
            [JsonProperty("source")]
            public string Source { get; set; }

            [JsonProperty("publicComment")]
            public string PublicComment { get; set; }

            [JsonProperty("createdAt")]
            public DateTime? CreatedAt { get; set; }

            public override string ToString()
            {
                return this.Source;
            }
        }

        public class ReviewInvitation
        {
            [JsonProperty("businessUnitId")]
            public string BusinessUnitId { get; set; }

            public override string ToString()
            {
                return this.BusinessUnitId;
            }
        }
    }
}
