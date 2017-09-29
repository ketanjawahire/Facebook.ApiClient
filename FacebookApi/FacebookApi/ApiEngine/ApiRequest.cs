using FacebookApi.Interfaces;
using System;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Represents a Facebook API requests
    /// </summary>
    public class ApiRequest
    {
        public enum RequestTypes
        {
            Get,
            Post,
            Paged,
        }

        public static IApiRequest Create(RequestTypes type, string url, ApiClient client)
        {
            switch (type)
            {
                case RequestTypes.Get:
                    return new GetRequest(url, client);
                case RequestTypes.Post:
                    return new PostRequest(url, client);
                case RequestTypes.Paged:
                    return new PagedRequest(url, client);
            }

            throw new NotImplementedException();
        }
    }
}
