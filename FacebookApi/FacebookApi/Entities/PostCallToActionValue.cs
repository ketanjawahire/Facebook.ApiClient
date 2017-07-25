using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    public class PostCallToActionValue
    {
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }
    }
}
