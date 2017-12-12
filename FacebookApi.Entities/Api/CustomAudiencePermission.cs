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
    /// Permissions for the custom audience based on viewer
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/custom-audience-permission/</para>
    /// </summary>
    public class CustomAudiencePermission : BaseEntity
    {
        /// <summary>
        /// Permission to edit the audience
        /// </summary>
        [DeserializeAs(Name = "can_edit")]
        [JsonProperty(PropertyName = "can_edit", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Permission to see insight of the audience
        /// </summary>
        [DeserializeAs(Name = "can_see_insight")]
        [JsonProperty(PropertyName = "can_see_insight", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? CanSeeInsight { get; set; }

        /// <summary>
        /// Capability to share audience based on gatekeeper
        /// </summary>
        [DeserializeAs(Name = "can_share")]
        [JsonProperty(PropertyName = "can_share", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? CanShare { get; set; }

        /// <summary>
        /// Capability to be used as seed for lookalike audience
        /// </summary>
        [DeserializeAs(Name = "subtype_supports_lookalike")]
        [JsonProperty(PropertyName = "subtype_supports_lookalike", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? SubtypeSupportsLookalike { get; set; }

        /// <summary>
        /// Capability to be used as seed for lookalike audience for recipient ad accounts
        /// </summary>
        [DeserializeAs(Name = "supports_recipient_lookalike")]
        [JsonProperty(PropertyName = "supports_recipient_lookalike", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? SupportsRecipientLookalike { get; set; }
    }
}
