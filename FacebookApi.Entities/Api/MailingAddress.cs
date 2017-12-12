using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A mailing address
    /// <para>https://developers.facebook.com/docs/graph-api/reference/mailing-address/</para>
    /// </summary>
    public class MailingAddress : BaseEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// Address city name
        /// </summary>
        [DeserializeAs(Name = "city")]
        [JsonProperty(PropertyName = "city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string City { get; set; }

        /// <summary>
        /// Page representing the address city
        /// </summary>
        [DeserializeAs(Name = "city_page")]
        [JsonProperty(PropertyName = "city_page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Page CityPage { get; set; }

        /// <summary>
        /// Country of the address
        /// </summary>
        [DeserializeAs(Name = "country")]
        [JsonProperty(PropertyName = "country", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        [DeserializeAs(Name = "postal_code")]
        [JsonProperty(PropertyName = "postal_code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Region or state of the address
        /// </summary>
        [DeserializeAs(Name = "region")]
        [JsonProperty(PropertyName = "region", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Region { get; set; }

        /// <summary>
        /// Street address
        /// </summary>
        [DeserializeAs(Name = "street1")]
        [JsonProperty(PropertyName = "street1", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Street1 { get; set; }

        /// <summary>
        /// Second part of the street address - apt, suite, etc
        /// </summary>
        [DeserializeAs(Name = "street2")]
        [JsonProperty(PropertyName = "street2", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Street2 { get; set; }
    }
}
