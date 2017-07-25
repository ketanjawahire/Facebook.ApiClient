using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Location node used with other objects in the Graph API.
    /// <see cref="https://developers.facebook.com/docs/graph-api/reference/location/"/>
    /// </summary>
    public class Location
    {
        /// <summary>
        /// City
        /// </summary>
        [DeserializeAs(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [DeserializeAs(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        /// The parent location if this location is located within another location
        /// </summary>
        [DeserializeAs(Name = "located_in")]
        public string LocatiedIn { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        public float? Longitude { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [DeserializeAs(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [DeserializeAs(Name = "state")]
        public string State { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        [DeserializeAs(Name = "street")]
        public string Street { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        [DeserializeAs(Name = "zip")]
        public string ZipCode { get; set; }
    }
}
