using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Orbital7.Apis.Trustpilot
{
    public class TrustpilotApiClient
    {
        private string ApiKey { get; set; }

        public TrustpilotApiClient(
            string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public async Task<BusinessUnitSearchResult> FindBusinessUnitAsync(
            string domainName)
        {
            string url = $"https://api.trustpilot.com/v1/business-units/find?apikey={this.ApiKey}&name={domainName}";
            var response = await QueryAsync(url);
            var result = JsonConvert.DeserializeObject<BusinessUnitSearchResult>(response);
            return result;
        }

        public async Task<BusinessUnit> GetBusinessUnitAsync(
            string businessUnitId)
        {
            string url = $"https://api.trustpilot.com/v1/business-units/{businessUnitId}?apikey={this.ApiKey}";
            var response = await QueryAsync(url);
            var result = JsonConvert.DeserializeObject<BusinessUnit>(response);
            return result;
        }

        public async Task<BusinessUnitReviews> GatherBusinessUnitReviewsAsync(
            string businessUnitId,
            int page,
            int perPage = 20,
            string orderBy = "createdat.desc",
            bool includeReportedReviews = false)
        {
            string url = $"https://api.trustpilot.com/v1/business-units/{businessUnitId}/reviews" +
                $"?page={page}" +
                $"&perPage={perPage}" +
                $"&orderBy={orderBy}" +
                $"&includeReportedReviews={includeReportedReviews.ToString().ToLower()}" +
                $"&apikey={this.ApiKey}";
            var response = await QueryAsync(url);
            var result = JsonConvert.DeserializeObject<BusinessUnitReviews>(response);
            result.page = page;
            result.perPage = perPage;
            return result;
        }

        public async Task<BusinessUnitReview> GetBusinessUnitReviewAsync(
            string reviewId)
        {
            string url = $"https://api.trustpilot.com/v1/reviews/{reviewId}?apikey={this.ApiKey}";
            var response = await QueryAsync(url);
            var result = JsonConvert.DeserializeObject<BusinessUnitReview>(response);
            return result;
        }

        private async Task<string> QueryAsync(
            string url)
        {
            // Create the request.
            var request = WebRequest.Create(url);
            
            // Send.
            try
            {
                using (var webResponse = await request.GetResponseAsync())
                {
                    return await webResponse.ReadAsStringAsync();
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    var response = await webException.Response.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TrustpilotApiError>(response);
                    throw new TrustpilotApiException(result);
                }
                else
                {
                    throw new Exception(webException.Message);
                }
            }
        }
    }
}
