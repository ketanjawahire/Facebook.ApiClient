using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    public class PostCallToAction
    {
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "value")]
        public PostCallToActionValue Value { get; set; }
    }
}
