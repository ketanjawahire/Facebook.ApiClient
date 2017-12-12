using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An User of an Ad Account Group
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account-group-users/</para>
    /// </summary>
    public class AdAccountGroupUsers : BaseEntity
    {
        /// <summary>
        /// The role of this user in the account group
        /// </summary>
        [DeserializeAs(Name = "role")]
        [JsonProperty(PropertyName = "role", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Role { get; set; }

        /// <summary>
        /// The ID of this user 
        /// </summary>
        [DeserializeAs(Name = "uid")]
        [JsonProperty(PropertyName = "uid", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long UId { get; set; }
    }
}
