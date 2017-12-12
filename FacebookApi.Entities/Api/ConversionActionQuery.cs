using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Conversion Action Query
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/conversion-action-query/</para>
    /// </summary>
    public class ConversionActionQuery : BaseEntity
    {
        /// <summary>
        /// Action type
        /// </summary>
        [DeserializeAs(Name = "action.type")]
        [JsonProperty(PropertyName = "action.type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> ActionType { get; set; }

        /// <summary>
        /// Application
        /// </summary>
        [DeserializeAs(Name = "application")]
        [JsonProperty(PropertyName = "application", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Application { get; set; }

        /// <summary>
        /// Rule based offsite conversion
        /// </summary>
        [DeserializeAs(Name = "conversion_id")]
        [JsonProperty(PropertyName = "conversion_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> ConversionId { get; set; }

        /// <summary>
        /// Creative
        /// </summary>
        [DeserializeAs(Name = "creative")]
        [JsonProperty(PropertyName = "creative", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Creative { get; set; }

        /// <summary>
        /// Dataset
        /// </summary>
        [DeserializeAs(Name = "dataset")]
        [JsonProperty(PropertyName = "dataset", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Dataset { get; set; }

        /// <summary>
        /// Event
        /// </summary>
        [DeserializeAs(Name = "event")]
        [JsonProperty(PropertyName = "event", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Event { get; set; }

        /// <summary>
        /// Event creator
        /// </summary>
        [DeserializeAs(Name = "event.creator")]
        [JsonProperty(PropertyName = "event.creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> EventCreater { get; set; }

        /// <summary>
        /// Event Type
        /// </summary>
        [DeserializeAs(Name = "event_type")]
        [JsonProperty(PropertyName = "event_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> EventType { get; set; }

        /// <summary>
        /// Facebook pixel id
        /// </summary>
        [DeserializeAs(Name = "fb_pixel")]
        [JsonProperty(PropertyName = "fb_pixel", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> FBPixel { get; set; }

        /// <summary>
        /// Facebook pixel event
        /// </summary>
        [DeserializeAs(Name = "fb_pixel_event")]
        [JsonProperty(PropertyName = "fb_pixel_event", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> FBPixelEvent { get; set; }

        /// <summary>
        /// Leadgen
        /// </summary>
        [DeserializeAs(Name = "leadgen")]
        [JsonProperty(PropertyName = "leadgen", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Leadgen { get; set; }

        /// <summary>
        /// Object
        /// </summary>
        [DeserializeAs(Name = "object")]
        [JsonProperty(PropertyName = "object", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Object { get; set; }

        /// <summary>
        /// Object domain
        /// </summary>
        [DeserializeAs(Name = "object.domain")]
        [JsonProperty(PropertyName = "object.domain", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> ObjectDomain { get; set; }

        /// <summary>
        /// Offer
        /// </summary>
        [DeserializeAs(Name = "offer")]
        [JsonProperty(PropertyName = "offer", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Offer { get; set; }

        /// <summary>
        /// Offer creator
        /// </summary>
        [DeserializeAs(Name = "offer.creator")]
        [JsonProperty(PropertyName = "offer.creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> OfferCreator { get; set; }

        /// <summary>
        /// Offsite pixel
        /// </summary>
        [DeserializeAs(Name = "offsite_pixel")]
        [JsonProperty(PropertyName = "offsite_pixel", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> OffsitePixel { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [DeserializeAs(Name = "page")]
        [JsonProperty(PropertyName = "page", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Page { get; set; }

        /// <summary>
        /// Page parent
        /// </summary>
        [DeserializeAs(Name = "page.parent")]
        [JsonProperty(PropertyName = "page.parent", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> PageParent { get; set; }

        /// <summary>
        /// Post
        /// </summary>
        [DeserializeAs(Name = "post")]
        [JsonProperty(PropertyName = "post", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Post { get; set; }

        /// <summary>
        /// Post object
        /// </summary>
        [DeserializeAs(Name = "post.object")]
        [JsonProperty(PropertyName = "post.object", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> PostObject { get; set; }

        /// <summary>
        /// Post object wall
        /// </summary>
        [DeserializeAs(Name = "post.object.wall")]
        [JsonProperty(PropertyName = "post.object.wall", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> PostObjectWall { get; set; }

        /// <summary>
        /// Post wall
        /// </summary>
        [DeserializeAs(Name = "post.wall")]
        [JsonProperty(PropertyName = "post.wall", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> PostWall { get; set; }

        /// <summary>
        /// Product set id
        /// </summary>
        [DeserializeAs(Name = "product_set_id")]
        [JsonProperty(PropertyName = "product_set_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> ProductSetId { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        [DeserializeAs(Name = "question")]
        [JsonProperty(PropertyName = "question", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Question { get; set; }

        /// <summary>
        /// Question creator
        /// </summary>
        [DeserializeAs(Name = "question.creator")]
        [JsonProperty(PropertyName = "question.creator", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> QuestionCreator { get; set; }

        /// <summary>
        /// Response
        /// </summary>
        [DeserializeAs(Name = "response")]
        [JsonProperty(PropertyName = "response", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Response { get; set; }

        /// <summary>
        /// Subtype
        /// </summary>
        [DeserializeAs(Name = "subtype")]
        [JsonProperty(PropertyName = "subtype", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Subtype { get; set; }
    }
}
