using FacebookApi.IApiEngine;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    public class Paging : IPaging
    {
        [DeserializeAs(Name = "before")]
        public string Before { get; set; }

        [DeserializeAs(Name = "after")]
        public string After { get; set; }

        [DeserializeAs(Name = "next")]
        public string Next { get; set; }

        [DeserializeAs(Name = "previous")]
        public string Previous { get; set; }
    }
}
