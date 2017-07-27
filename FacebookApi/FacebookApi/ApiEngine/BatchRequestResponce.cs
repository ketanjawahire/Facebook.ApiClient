using System.Collections.Generic;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class BatchRequestResponce : IBatchRequestResponce
    {
        [DeserializeAs(Name = "code")]
        public string Code { get; set; }

        [DeserializeAs(Name = "headers")]
        public Dictionary<string, string> Headers { get; set; }

        [DeserializeAs(Name = "body")]
        public string Body { get; set; }
    }
}
