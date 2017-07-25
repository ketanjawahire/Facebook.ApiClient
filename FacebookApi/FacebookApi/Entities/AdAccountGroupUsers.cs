using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An User of an Ad Account Group
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account-group-users/</para>
    /// </summary>
    public class AdAccountGroupUsers
    {
        /// <summary>
        /// The role of this user in the account group
        /// </summary>
        [DeserializeAs(Name = "role")]
        public int Role { get; set; }

        /// <summary>
        /// The ID of this user 
        /// </summary>
        [DeserializeAs(Name = "uid")]
        public long UId { get; set; }
    }
}
