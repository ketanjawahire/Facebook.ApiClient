namespace Facebook.ApiClient.Entities.ApiEngine
{
    /// <summary>
    /// Represents Facebook Batch Request
    /// </summary>
    public class BatchRequest
    {
        ///// <summary>
        ///// Batch parameters
        ///// </summary>
        //public IList<ApiRequestParameter> BatchParameters { get; }

        ///// <summary>
        ///// List of request inside batch
        ///// </summary>
        //public IList<BatchRequestParameters> Requests { get; }

        ///// <summary>
        ///// Request method
        ///// </summary>
        //public ApiRequestHttpMethod Method { get;}

        ///// <summary>
        ///// Request Uri
        ///// </summary>
        //public Uri RequestUri { get; private set; }

        ///// <summary>
        ///// Batch request parameters
        ///// </summary>
        //public IList<ApiRequestParameter> RequestParameters { get; private set; }

        ///// <summary>
        ///// <see cref="FacebookApi.ApiEngine.ApiClient"/> to use to execute API request
        ///// </summary>
        //public ApiClient Client { get; }

        ///// <summary>
        ///// Initialize new instance of <see cref="BatchRequest"/>
        ///// </summary>
        //public BatchRequest(ApiClient client, ApiRequestHttpMethod method)
        //{
        //    Client = client;
        //    Method = method;
        //    BatchParameters = new List<ApiRequestParameter>();
        //    Requests = new List<BatchRequestParameters>();
        //}


        ////still half baked
        ///// <summary>
        ///// Execute batch request
        ///// </summary>
        ///// <param name="batchRequest">Batch request to execute</param>
        ///// <returns></returns>
        //public IApiResponse<List<BatchResponse>> ExecuteBatch(BatchRequest batchRequest)
        //{
        //    var request = new RestRequest(Method.POST);

        //    if (batchRequest.BatchParameters.Any())
        //    {
        //        foreach (var parameter in batchRequest.BatchParameters)
        //        {
        //            request.AddParameter(parameter.Name, parameter.Value, (ParameterType)((int)parameter.Type));
        //        }
        //    }

        //    var test = batchRequest.Requests.Select(e =>
        //    {
        //        dynamic temp = new ExpandoObject();

        //        if (e.Body != null)
        //        {
        //            if (e.Method == ApiRequestHttpMethod.GET)
        //            {
        //                e.Url =
        //                    $"{e.Url}{(e.Url.Contains("?") ? "&" : "?")}{string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"))}";
        //            }
        //            else
        //            {
        //                temp.body = string.Join("&", e.Body.Select(p => $"{p.Name}={HttpUtility.UrlEncode(p.Value)}"));
        //            }
        //        }

        //        if (e.DependsOn != null)
        //        {
        //            temp.depend_on = e.DependsOn.Name;
        //        }

        //        temp.name = e.Name;
        //        temp.method = e.Method.ToString();
        //        temp.relative_url = e.Url;

        //        return temp;
        //    });

        //    request.AddParameter("batch", SimpleJson.SerializeObject(test.ToArray()), ParameterType.GetOrPost);
        //    request.AddParameter("access_token", AccessToken, ParameterType.QueryString);

        //    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

        //    var response = (new RestClient("https://graph.facebook.com/")).Execute<List<BatchResponse>>(request);

        //    return new ApiResponse<List<BatchResponse>>(response.Data, response.Headers, GetExceptionsFromApiResponse(response));

        //}

    }
}
