using System.Collections.Generic;
using FacebookApi.Entities.Enumerations;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// An ad account group allows managing user access to multiple Facebook ad accounts as a single unit.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account-group/</para>
    /// </summary>
    public class AdAccountGroupResult
    {
        /// <summary>
        /// ID of this ad account group, it's the same as account_group_id
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of this ad account group
        /// </summary>
        [DeserializeAs(Name = "account_group_id")]
        public long AccountGroupId { get; set; }

        /// <summary>
        /// The accounts in an account group in which the users have access
        /// </summary>
        [DeserializeAs(Name = "accounts")]
        public IList<AdAccount> Accounts { get; set; }
        
        /// <summary>
        /// Name for the account group.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Determines whether the account has a status of active (1) or deleted (2)
        /// </summary>
        [DeserializeAs(Name = "status")]
        public AdAccountStatus Status { get; set; }

        /// <summary>
        /// The users who own the ad account group
        /// </summary>
        [DeserializeAs(Name = "users")]
        public IList<AdAccountGroupUsers> AdAccountGroupUsers { get; set; }
    }
}
