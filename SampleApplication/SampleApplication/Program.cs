using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.ApiClient.ApiEngine;
using Facebook.ApiClient.Entities.Api;
using Facebook.ApiClient.Interfaces;

namespace SampleApplication
{
    class Program
    {
        private static ApiClient _client;
        private static string _accessToken = "your_access_token_here";
        private static long _campaignId = 0;

        static void Main(string[] args)
        {
            _client = new ApiClient(_accessToken);

            GetUserAdAaccounts();

            GetAdAccountCampaigns();

            GetCampaignById(_campaignId);
        }

        public static void GetUserAdAaccounts()
        {
            //create new instance of PagedApiRequest
            var pagedRequest = (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, "me/adaccounts", _client);

            //specify all query parameters.
            pagedRequest.AddQueryParameter("fields",
                "account_id,account_status,age,agency_client_declaration,amount_spent,attribution_spec,balance,business,business_city,business_country_code,business_name,business_state,business_street,business_street2,business_zip,can_create_brand_lift_study,capabilities,created_time,currency,disable_reason,end_advertiser,end_advertiser_name,failed_delivery_checks,funding_source,funding_source_details,has_migrated_permissions,id,io_number,is_attribution_spec_system_default,is_direct_deals_enabled,is_notifications_enabled,is_personal,is_prepay_account,is_tax_id_required,line_numbers,media_agency,min_campaign_group_spend_cap,min_daily_budget,name,next_bill_date,offsite_pixels_tos_accepted,owner,partner,rf_spec,salesforce_invoice_group_id,spend_cap,tax_id,tax_id_status,tax_id_type,timezone_id,timezone_name,timezone_offset_hours_utc,tos_accepted,user_role,activities");

            //add paged api request limit. This will added as limit parameter to the request
            pagedRequest.AddPageLimit(20);

            //Once request is ready then execute it to do API call & fetch data
            var result = new List<AdAccount>();

            //following will do API call & fetch data & then map it to class AdAccount
            var pagedRequestResponse = pagedRequest.ExecutePage<AdAccount>();

            //check for exceptions
            var exceptions = pagedRequestResponse.GetExceptions().ToList();
            if (exceptions.Any())
            {
                Console.WriteLine("Encountered excecption while getting data from API. Details as following.");
                foreach (var exception in exceptions)
                {
                    Console.WriteLine("exception : {0}", exception.ToString());
                }

                return;
            }

            //For paged API requests, first check if data is available or not
            if (pagedRequestResponse.IsDataAvailable())
            {
                //if API data is available then add it to the result list.
                result.AddRange(pagedRequestResponse.GetResultData());

                //try to fetch next page data from API using helper method IsNextPageDataAvailable(). 
                //Loop continues until all pages are fetched from API
                while (pagedRequestResponse.IsNextPageDataAvailable())
                {
                    pagedRequestResponse = pagedRequestResponse.GetNextPageData();

                    //check for exceptions
                    exceptions = pagedRequestResponse.GetExceptions().ToList();
                    if (exceptions.Any())
                    {
                        Console.WriteLine("Encountered excecption while getting data from API. Details as following.");
                        foreach (var exception in exceptions)
                        {
                            Console.WriteLine("exception : {0}", exception.ToString());
                        }

                        return;
                    }

                    result.AddRange(pagedRequestResponse.GetResultData());
                }
            }

            //print information fetched from API
            foreach (var adAccount in result)
            {
                Console.WriteLine("Id : {0}, Name : {1}, Status : {2}", adAccount.AccountId, adAccount.Name,
                    adAccount.AccountStatus);
            }

            Console.ReadLine();
        }

        public static void GetAdAccountCampaigns()
        {
            //create new instance of PagedApiRequest
            var pagedRequest =
                (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, "{account_id}/campaigns", _client);

            //add values for url segments
            pagedRequest.AddUrlSegment("account_id", "act_");

            //specify all query parameters.
            pagedRequest.AddQueryParameter("fields", string.Join(",", Campaign.GetApiSelectors()));

            //add paged api request limit. This will added as limit parameter to the request
            pagedRequest.AddPageLimit(20);

            //Once request is ready then execute it to do API call & fetch data
            var result = new List<Campaign>();
            var pagedRequestResponse = pagedRequest.ExecutePage<Campaign>();

            //check for exceptions
            var exceptions = pagedRequestResponse.GetExceptions().ToList();
            if (exceptions.Any())
            {
                Console.WriteLine("Encountered excecption while getting data from API. Details as following.");
                foreach (var exception in exceptions)
                {
                    Console.WriteLine("exception : {0}", exception.ToString());
                }

                return;
            }

            //For paged API requests, first check if data is available or not
            if (pagedRequestResponse.IsDataAvailable())
            {
                //if API data is available then add it to the result list.
                result.AddRange(pagedRequestResponse.GetResultData());

                //try to fetch next page data from API using helper method IsNextPageDataAvailable(). 
                //Loop continues until all pages are fetched from API
                while (pagedRequestResponse.IsNextPageDataAvailable())
                {
                    pagedRequestResponse = pagedRequestResponse.GetNextPageData();

                    //check for exceptions
                    exceptions = pagedRequestResponse.GetExceptions().ToList();
                    if (exceptions.Any())
                    {
                        Console.WriteLine("Encountered excecption while getting data from API. Details as following.");
                        foreach (var exception in exceptions)
                        {
                            Console.WriteLine("exception : {0}", exception.ToString());
                        }

                        return;
                    }

                    result.AddRange(pagedRequestResponse.GetResultData());
                }
            }

            //print information fetched from API
            foreach (var campaign in result)
            {
                Console.WriteLine("Id : {0}, Name : {1}, Status : {2}", campaign.Id, campaign.Name, campaign.Status);
            }

            Console.ReadLine();
        }

        public static void GetCampaignById(long campaignId)
        {
            //create new Get API request
            var request = (IGetRequest) ApiRequest.Create(ApiRequest.RequestType.Get, "{campaign_id}", _client);

            //provide replacement value for url paramter campaign_id
            request.AddUrlSegment("campaign_id", campaignId.ToString());

            //Add API request query parmater
            request.AddQueryParameter("fields", string.Join(",", Campaign.GetApiSelectors()));

            //execute API request & fetch data from API
            var result = request.Execute<Campaign>();

            //check for exceptions
            var exceptions = result.GetExceptions().ToList();
            if (exceptions.Any())
            {
                Console.WriteLine("Encountered excecption while getting data from API. Details as following.");
                foreach (var exception in exceptions)
                {
                    Console.WriteLine("exception : {0}", exception.ToString());
                }

                return;
            }

            var campaign = result.GetResult();
            Console.WriteLine("Id : {0}, Name : {1}", campaign.Id, campaign.Name);
            Console.ReadLine();
        }
    }
}
