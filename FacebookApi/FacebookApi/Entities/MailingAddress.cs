using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A mailing address
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/mailing-address/"/>
    /// </summary>
    public class MailingAddress
    {
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Address city name
        /// </summary>
        [DeserializeAs(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// Page representing the address city
        /// </summary>
        [DeserializeAs(Name = "city_page")]
        public Page CityPage { get; set; }

        /// <summary>
        /// Country of the address
        /// </summary>
        [DeserializeAs(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        [DeserializeAs(Name = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Region or state of the address
        /// </summary>
        [DeserializeAs(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Street address
        /// </summary>
        [DeserializeAs(Name = "street1")]
        public string Street1 { get; set; }

        /// <summary>
        /// Second part of the street address - apt, suite, etc
        /// </summary>
        [DeserializeAs(Name = "street2")]
        public string Street2 { get; set; }
    }
}
