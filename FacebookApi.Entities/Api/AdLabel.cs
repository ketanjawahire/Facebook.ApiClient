using System;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An AdLabel
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-label/</para>
    /// </summary>
    public class AdLabel
    {
        /// <summary>
        /// Ad Label ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Ad Account
        /// </summary>
        [DeserializeAs(Name = "account")]
        public AdAccount Account { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Ad Label name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Updated time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public string UpdatedTime { get; set; }
    }
}
