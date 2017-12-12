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
    /// Ad Action stats
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ads-action-stats/</para>
    /// </summary>
    public class AdActionStats : BaseEntity
    {
        /// <summary>
        /// Metric value of attribution window "1 day after clicking the ad"
        /// </summary>
        [DeserializeAs(Name = "1d_click")]
        [JsonProperty(PropertyName = "1d_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _1dClick { get; set; }

        /// <summary>
        /// Metric value of attribution window "1 day after viewing the ad"
        /// </summary>
        [DeserializeAs(Name = "1d_view")]
        [JsonProperty(PropertyName = "1d_view", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _1dView { get; set; }

        /// <summary>
        /// Metric value of attribution window "28 days after clicking the ad"
        /// </summary>
        [DeserializeAs(Name = "28d_click")]
        [JsonProperty(PropertyName = "28d_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _28dClick { get; set; }

        /// <summary>
        /// Metric value of attribution window "28 days after viewing the ad"
        /// </summary>
        [DeserializeAs(Name = "28d_view")]
        [JsonProperty(PropertyName = "28d_view", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _28dView { get; set; }

        /// <summary>
        /// Metric value of attribution window "7 days after clicking the ad"
        /// </summary>
        [DeserializeAs(Name = "7d_click")]
        [JsonProperty(PropertyName = "7d_click", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _7dClick { get; set; }

        /// <summary>
        /// Metric value of attribution window "7 days after viewing the ad"
        /// </summary>
        [DeserializeAs(Name = "7d_view")]
        [JsonProperty(PropertyName = "7d_view", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string _7dView { get; set; }

        /// <summary>
        /// Name of a component within a Canvas ad
        /// </summary>
        [DeserializeAs(Name = "action_canvas_component_name")]
        [JsonProperty(PropertyName = "action_canvas_component_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionCanvasComponentName { get; set; }

        /// <summary>
        /// The ID of the specific carousel card that people engaged with when they saw your ad.
        /// </summary>
        [DeserializeAs(Name = "action_carousel_card_id")]
        [JsonProperty(PropertyName = "action_carousel_card_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionCarouselCardId { get; set; }

        /// <summary>
        /// The specific carousel card that people engaged with when they saw your ad. The cards are identified by their headlines.
        /// </summary>
        [DeserializeAs(Name = "action_carousel_card_name")]
        [JsonProperty(PropertyName = "action_carousel_card_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionCarouselCardName { get; set; }

        /// <summary>
        /// The destination where people go after clicking on your ad. This could be your Facebook Page, an external URL for your conversion pixel or an app configured with the software development kit (SDK).
        /// </summary>
        [DeserializeAs(Name = "action_destination")]
        [JsonProperty(PropertyName = "action_destination", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionDestination { get; set; }

        /// <summary>
        /// The device on which the conversion event you're tracking occurred
        /// </summary>
        [DeserializeAs(Name = "action_device")]
        [JsonProperty(PropertyName = "action_device", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionDevice { get; set; }

        /// <summary>
        /// The destination where people go after clicking link on your ad that directs people off Facebook.
        /// </summary>
        [DeserializeAs(Name = "action_link_click_destination")]
        [JsonProperty(PropertyName = "action_link_click_destination", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionLinkClickDestination { get; set; }

        /// <summary>
        /// The number of reactions on your ads or boosted posts. The reactions button on an ad allows people to share different reactions on its content: Like, Love, Haha, Wow, Sad or Angry.
        /// </summary>
        [DeserializeAs(Name = "action_reaction")]
        [JsonProperty(PropertyName = "action_reaction", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionReaction { get; set; }

        /// <summary>
        /// The id of destination where people go after clicking on your ad. This could be your Facebook Page, an external URL for your conversion pixel or an app configured with the software development kit 
        /// </summary>
        [DeserializeAs(Name = "action_target_id")]
        [JsonProperty(PropertyName = "action_target_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionTargetId { get; set; }

        /// <summary>
        /// The kind of actions taken on your ad, Page, app or event after your ad was served to someone, even if they didn't click on it.
        /// </summary>
        [DeserializeAs(Name = "action_type")]
        [JsonProperty(PropertyName = "action_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionType { get; set; }

        /// <summary>
        /// The sound status (on/off) when user watches your video ad.
        /// </summary>
        [DeserializeAs(Name = "action_video_sound")]
        [JsonProperty(PropertyName = "action_video_sound", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionVideoSound { get; set; }

        /// <summary>
        /// Video metrics breakdown.
        /// </summary>
        [DeserializeAs(Name = "action_video_type")]
        [JsonProperty(PropertyName = "action_video_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ActionVideoType { get; set; }

        /// <summary>
        /// Metric value of default attribution window
        /// </summary>
        [DeserializeAs(Name = "value")]
        [JsonProperty(PropertyName = "value", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Value { get; set; }
    }
}
