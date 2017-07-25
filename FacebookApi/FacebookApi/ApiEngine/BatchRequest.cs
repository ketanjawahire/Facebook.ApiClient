using System.Collections.Generic;

namespace FacebookApi.ApiEngine
{
    public class BatchRequest : IBatchRequest
    {
        public IList<ApiRequestParameter> BatchParameters { get; set; }

        public IList<BatchRequestParameters> Requests { get; set; }

        public BatchRequest()
        {
            BatchParameters = new List<ApiRequestParameter>();
            Requests = new List<BatchRequestParameters>();
        }
    }
}
