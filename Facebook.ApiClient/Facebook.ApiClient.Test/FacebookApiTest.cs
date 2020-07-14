using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facebook.ApiClient.ApiEngine;
using Facebook.ApiClient.Entities.Api;
using Facebook.ApiClient.Interfaces;
using Facebook.ApiClient.Test.Fixtures;
using RestSharp;
using Xunit;

namespace Facebook.ApiClient.Test
{
    public class FacebookApiTest : IClassFixture<ConfigurationFixture>, IClassFixture<ApiFixture>
    {
        public ApiFixture ApiFixture { get; }

        public ConfigurationFixture ConfigurationFixture { get; }

        public FacebookApiTest(ApiFixture apiFixture, ConfigurationFixture configurationFixture)
        {
            ApiFixture = apiFixture;
            ConfigurationFixture = configurationFixture;
        }

        [Fact]
        public async Task GetCorrectNestedPagedData()
        {
            var api = CreateApiClient();

            var request = (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, "{accountId}", api);

            request.AddUrlSegment("accountId", "act_1979784652334091");
            request.AddQueryParameter("fields","adsets{id,account_id,campaignid}");
            

            var response = await request.ExecuteNestedPageAsync<AdSet>();

            Assert.NotNull(response.GetResultData());

        }

        [Fact]
        public async Task GetAccountData()
        {
            var api = CreateApiClient();
            var pagedRequest = (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, "me/adaccounts", api);

            // Specify all query parameters.
            pagedRequest.AddQueryParameter(
                "fields",
                "id,account_id,account_status,age,created_time,amount_spent");

            pagedRequest.AddPageLimit(20);

            var response = await pagedRequest.ExecutePageAsync<AdAccount>();

            Assert.NotNull(response.GetResultData());
        }

        [Fact]
        public async Task GetInsightsPagedData()
        {
            List<Insight> result = new List<Insight>();
            var startDate = new DateTimeOffset(2019, 3, 6, 0, 0, 0, new TimeSpan(0, 5, 0, 0));
            var endDate = new DateTimeOffset(2019, 3, 7, 0, 0, 0, new TimeSpan(0, 5, 0, 0));

            var api = CreateApiClient();
            var request = (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, "{adAccount}/insights?", api);
            request.AddUrlSegment("adAccount", "act_1979784652334091");

            var start = startDate.ToString("yyyy-MM-dd");
            var end = endDate.ToString("yyyy-MM-dd");

            request.AddQueryParameter("fields", "ad_id,adset_id,campaign_name,campaign_id,spend");
            request.AddQueryParameter("level", "ad");
            request.AddQueryParameter("time_range[since]", start);
            request.AddQueryParameter("time_range[until]", end);
            request.AddQueryParameter("time_increment", "1");
            request.AddQueryParameter("filtering", "[{\"field\":\"campaign.delivery_info\",\"operator\":\"IN\",\"value\":[\"active\"]},{\"field\":\"ad.effective_status\",\"operator\":\"IN\",\"value\":[\"ACTIVE\"]},{\"field\":\"adset.spend\",\"operator\":\"NOT_EQUAL\",\"value\":\"0\"}]");

            var response = await request.ExecutePageAsync<Insight>();

            if (response.IsDataAvailable())
            {
                result.AddRange(response.GetResultData());

                while (response.IsNextPageDataAvailable())
                {
                    response = response.GetNextPageData();

                    //ThrowIfResponseHasExceptions(response);

                    result.AddRange(response.GetResultData());
                }
            }
            Assert.NotEmpty(response.GetResultData());


        }

        private ApiEngine.ApiClient CreateApiClient()
        {
            return ApiFixture.GetApiClient(ConfigurationFixture.Configuration);
        }

    }
}
