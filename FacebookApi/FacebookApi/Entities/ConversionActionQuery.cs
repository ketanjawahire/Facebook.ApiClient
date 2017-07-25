using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Conversion Action Query
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/conversion-action-query/</para>
    /// </summary>
    public class ConversionActionQuery
    {
        /// <summary>
        /// Action type
        /// </summary>
        [DeserializeAs(Name = "action.type")]
        public List<string> ActionType { get; set; }

        /// <summary>
        /// Application
        /// </summary>
        [DeserializeAs(Name = "application")]
        public List<string> Application { get; set; }

        /// <summary>
        /// Rule based offsite conversion
        /// </summary>
        [DeserializeAs(Name = "conversion_id")]
        public List<string> ConversionId { get; set; }

        /// <summary>
        /// Creative
        /// </summary>
        [DeserializeAs(Name = "creative")]
        public List<string> Creative { get; set; }

        /// <summary>
        /// Dataset
        /// </summary>
        [DeserializeAs(Name = "dataset")]
        public List<string> Dataset { get; set; }

        /// <summary>
        /// Event
        /// </summary>
        [DeserializeAs(Name = "event")]
        public List<string> Event { get; set; }

        /// <summary>
        /// Event creator
        /// </summary>
        [DeserializeAs(Name = "event.creator")]
        public List<string> EventCreater { get; set; }

        /// <summary>
        /// Event Type
        /// </summary>
        [DeserializeAs(Name = "event_type")]
        public List<string> EventType { get; set; }

        /// <summary>
        /// Facebook pixel id
        /// </summary>
        [DeserializeAs(Name = "fb_pixel")]
        public List<string> FBPixel { get; set; }

        /// <summary>
        /// Facebook pixel event
        /// </summary>
        [DeserializeAs(Name = "fb_pixel_event")]
        public List<string> FBPixelEvent { get; set; }

        /// <summary>
        /// Leadgen
        /// </summary>
        [DeserializeAs(Name = "leadgen")]
        public List<string> Leadgen { get; set; }

        /// <summary>
        /// Object
        /// </summary>
        [DeserializeAs(Name = "object")]
        public List<string> Object { get; set; }

        /// <summary>
        /// Object domain
        /// </summary>
        [DeserializeAs(Name = "object.domain")]
        public List<string> ObjectDomain { get; set; }

        /// <summary>
        /// Offer
        /// </summary>
        [DeserializeAs(Name = "offer")]
        public List<string> Offer { get; set; }

        /// <summary>
        /// Offer creator
        /// </summary>
        [DeserializeAs(Name = "offer.creator")]
        public List<string> OfferCreator { get; set; }

        /// <summary>
        /// Offsite pixel
        /// </summary>
        [DeserializeAs(Name = "offsite_pixel")]
        public List<string> OffsitePixel { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [DeserializeAs(Name = "page")]
        public List<string> Page { get; set; }

        /// <summary>
        /// Page parent
        /// </summary>
        [DeserializeAs(Name = "page.parent")]
        public List<string> PageParent { get; set; }

        /// <summary>
        /// Post
        /// </summary>
        [DeserializeAs(Name = "post")]
        public List<string> Post { get; set; }

        /// <summary>
        /// Post object
        /// </summary>
        [DeserializeAs(Name = "post.object")]
        public List<string> PostObject { get; set; }

        /// <summary>
        /// Post object wall
        /// </summary>
        [DeserializeAs(Name = "post.object.wall")]
        public List<string> PostObjectWall { get; set; }

        /// <summary>
        /// Post wall
        /// </summary>
        [DeserializeAs(Name = "post.wall")]
        public List<string> PostWall { get; set; }

        /// <summary>
        /// Product set id
        /// </summary>
        [DeserializeAs(Name = "product_set_id")]
        public List<string> ProductSetId { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        [DeserializeAs(Name = "question")]
        public List<string> Question { get; set; }

        /// <summary>
        /// Question creator
        /// </summary>
        [DeserializeAs(Name = "question.creator")]
        public List<string> QuestionCreator { get; set; }

        /// <summary>
        /// Response
        /// </summary>
        [DeserializeAs(Name = "response")]
        public List<string> Response { get; set; }

        /// <summary>
        /// Subtype
        /// </summary>
        [DeserializeAs(Name = "subtype")]
        public List<string> Subtype { get; set; }
    }
}
