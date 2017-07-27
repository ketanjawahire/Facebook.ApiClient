using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using FacebookApi.Enums;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using RestSharp.Extensions.MonoHttp;

namespace FacebookApi.ApiEngine
{
    public class BatchRequest : IBatchRequest
    {
        public IList<ApiRequestParameter> BatchParameters { get; set; }

        public IList<BatchRequestParameters> Requests { get; set; }


        public ApiRequestHttpMethod Method { get; private set; }

        public string RequestUri { get; private set; }

        public IList<ApiRequestParameter> RequestParameters { get; private set; }

        public ApiClient ApiClient { get; private set; }

        public BatchRequest()
        {
            BatchParameters = new List<ApiRequestParameter>();
            Requests = new List<BatchRequestParameters>();
        }

        //still half baked
        public IApiResponse<List<BatchResponse>> ExecuteBatch(BatchRequest batchRequest)
        {
            //var request = new RestRequest(Method.POST);

            //if (batchRequest.BatchParameters.Any())
            //{
            //    foreach (var parameter in batchRequest.BatchParameters)
            //    {
            //        request.AddParameter(parameter.Name, parameter.Value, (ParameterType)((int)parameter.Type));
            //    }
            //}

            //var test = batchRequest.Requests.Select(e =>
            //{
            //    dynamic temp = new ExpandoObject();

            //    if (e.Body != null)
            //    {
            //        if (e.Method == ApiRequestHttpMethod.GET)
            //        {
            //            e.Url =
            //                $"{e.Url}{(e.Url.Contains("?") ? "&" : "?")}{string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"))}";
            //        }
            //        else
            //        {
            //            temp.body = string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"));
            //        }
            //    }

            //    if (e.DependsOn != null)
            //    {
            //        temp.depend_on = e.DependsOn.Name;
            //    }

            //    temp.name = e.Name;
            //    temp.method = e.Method.ToString();
            //    temp.relative_url = e.Url;

            //    return temp;
            //});

            //request.AddParameter("batch", SimpleJson.SerializeObject(test.ToArray()), ParameterType.GetOrPost);
            //request.AddParameter("access_token", AccessToken, ParameterType.QueryString);

            //request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            //var response = (new RestClient("https://graph.facebook.com/")).Execute<List<BatchResponse>>(request);

            //return new ApiResponse<List<BatchResponse>>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));

            throw new NotImplementedException("SDK does not support batch request as of now.");
        }

    }
}
