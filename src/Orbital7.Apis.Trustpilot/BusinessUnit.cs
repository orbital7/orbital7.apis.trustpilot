using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Orbital7.Apis.Trustpilot
{
    public class BusinessUnit
        : BusinessUnitSearchResult
    {
        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("numberOfReviews")]
        public BusinessUnitNumberOfReviews NumberOfReviews { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("score")]
        public BusinessUnitScore Score { get; set; }

        [JsonProperty("warning")]
        public string Warning { get; set; }

        public class BusinessUnitNumberOfReviews
        {
            [JsonProperty("total")]
            public int Total { get; set; }

            [JsonProperty("usedForTrustScoreCalculation")]
            public int UsedForTrustScoreCalculation { get; set; }

            [JsonProperty("oneStar")]
            public int OneStar { get; set; }

            [JsonProperty("twoStars")]
            public int TwoStars { get; set; }

            [JsonProperty("threeStars")]
            public int ThreeStars { get; set; }

            [JsonProperty("fourStars")]
            public int FourStars { get; set; }

            [JsonProperty("fiveStars")]
            public int FiveStars { get; set; }

            public override string ToString()
            {
                return this.Total.ToString();
            }
        }

        public class BusinessUnitScore
        {
            [JsonProperty("trustScore")]
            public double TrustScore { get; set; }

            [JsonProperty("stars")]
            public double Stars { get; set; }

            public override string ToString()
            {
                return this.TrustScore.ToString();
            }
        }
    }
}
