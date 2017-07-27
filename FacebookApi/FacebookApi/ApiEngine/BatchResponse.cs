using System.Collections.Generic;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class BatchResponse : IBatchResponse
    {
        [DeserializeAs(Name = "code")]
        public string Code { get; set; }

        [DeserializeAs(Name = "headers")]
        public List<BatchResponceHeader> Headers { get; set; }

        [DeserializeAs(Name = "body")]
        public string Body { get; set; }
    }
}
