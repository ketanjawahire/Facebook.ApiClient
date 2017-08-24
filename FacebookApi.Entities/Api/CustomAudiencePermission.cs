using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Permissions for the custom audience based on viewer
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-permission/</para>
    /// </summary>
    public class CustomAudiencePermission
    {
        /// <summary>
        /// Permission to edit the audience
        /// </summary>
        [DeserializeAs(Name = "can_edit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Permission to see insight of the audience
        /// </summary>
        [DeserializeAs(Name = "can_see_insight")]
        public bool? CanSeeInsight { get; set; }

        /// <summary>
        /// Capability to share audience based on gatekeeper
        /// </summary>
        [DeserializeAs(Name = "can_share")]
        public bool? CanShare { get; set; }

        /// <summary>
        /// Capability to be used as seed for lookalike audience
        /// </summary>
        [DeserializeAs(Name = "subtype_supports_lookalike")]
        public bool? SubtypeSupportsLookalike { get; set; }

        /// <summary>
        /// Capability to be used as seed for lookalike audience for recipient ad accounts
        /// </summary>
        [DeserializeAs(Name = "supports_recipient_lookalike")]
        public bool? SupportsRecipientLookalike { get; set; }
    }
}
