using FacebookApi.Interfaces.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class BatchResponceHeader : IBatchResponceHeader
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}
