using System.Collections.Generic;
using FacebookApi.Enums;
using FacebookApi.IApiEngine;

namespace FacebookApi.ApiEngine
{
    public class BatchRequestParameters : IBatchRequestParameters
    {
        public string Name { get; set; }

        public ApiRequestHttpMethod Method { get; set; }

        public string Url { get; set; }

        public IList<BatchRequestBodyParameter> Body { get; set; }

        public BatchRequestParameters DependsOn { get; set; }


        public BatchRequestParameters()
        {
            Body = new List<BatchRequestBodyParameter>();
        }
    }
}
