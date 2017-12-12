using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A Facebook pixel is a small piece of JavaScript code that an advertiser places on every page of their website. 
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ads-pixel/</para>
    /// </summary>
    public class AdsPixel : BaseEntity
    {
        /// <summary>
        /// ID of the pixel
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// Pixel code to be placed on the website
        /// </summary>
        [DeserializeAs(Name = "code")]
        [JsonProperty(PropertyName = "code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Code { get; set; }

        /// <summary>
        /// Time at which the pixel was created
        /// </summary>
        [DeserializeAs(Name = "creation_time")]
        [JsonProperty(PropertyName = "creation_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The user who created this pixel
        /// </summary>
        [DeserializeAs(Name = "creator")]
        [JsonProperty(PropertyName = "creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public User Creator { get; set; }

        /// <summary>
        /// Flag stands for if a pixel is created by busines
        /// </summary>
        [DeserializeAs(Name = "is_created_by_business")]
        [JsonProperty(PropertyName = "is_created_by_business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? IsCreatedByBusiness { get; set; }

        /// <summary>
        /// Time at which the pixel was last fired
        /// </summary>
        [DeserializeAs(Name = "last_fired_time")]
        [JsonProperty(PropertyName = "last_fired_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LastFiredTime { get; set; }

        /// <summary>
        /// Name of the pixel
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Ad Account that owns this pixel
        /// </summary>
        [DeserializeAs(Name = "owner_ad_account")]
        [JsonProperty(PropertyName = "owner_ad_account", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdAccount OwnerAdAccount { get; set; }

        /// <summary>
        /// ID of the business that owns this pixel or null if the pixel has not been claimed by any business yet.
        /// </summary>
        [DeserializeAs(Name = "owner_business")]
        [JsonProperty(PropertyName = "owner_business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? OwnerBusiness { get; set; }
    }
}
