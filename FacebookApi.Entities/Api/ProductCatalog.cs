using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Represents a catalog for your business you can use to deliver ads with Dynamic Ads.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-catalog/</para>
    /// </summary>
    public class ProductCatalog : BaseEntity
    {
        /// <summary>
        /// ID of a catalog.
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// Business that owns a catalog
        /// </summary>
        [DeserializeAs(Name = "business")]
        [JsonProperty(PropertyName = "business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Business Business { get; set; }

        /// <summary>
        /// Image display settings such as background cropping and padding of items in the catalog for different Dynamic Ad formats.
        /// </summary>
        [DeserializeAs(Name = "da_display_settings")]
        [JsonProperty(PropertyName = "da_display_settings", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ProductCatalogImageSettings DisplaySettings { get; set; }

        /// <summary>
        /// The URL for the default image, which is used for products without images, or when the product image is temporarily unavailable.
        /// </summary>
        [DeserializeAs(Name = "default_image_url")]
        [JsonProperty(PropertyName = "default_image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DefaultImageUrl { get; set; }

        /// <summary>
        /// The URL for the fallback image. This is used as the image for auto-generated dynamic items.
        /// </summary>
        [DeserializeAs(Name = "fallback_image_url")]
        [JsonProperty(PropertyName = "fallback_image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FallbackImageUrl { get; set; }

        /// <summary>
        /// The total number of feeds used by a catalog.
        /// </summary>
        [DeserializeAs(Name = "feed_count")]
        [JsonProperty(PropertyName = "feed_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int FeedCount { get; set; }

        /// <summary>
        /// Flag to enable padding for images in a catalog when used in single image ads. The image will be padded to a 1.91:1 aspect ratio.
        /// </summary>
        [DeserializeAs(Name = "source_ad")]
        [JsonProperty(PropertyName = "image_padding_landscape", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool ImagePalldingLadscape { get; set; }

        /// <summary>
        /// Flag to enable padding of images in a catalog when used in carousel ads. The image will be padded to a 1:1 aspect ratio.
        /// </summary>
        [DeserializeAs(Name = "image_padding_square")]
        [JsonProperty(PropertyName = "image_padding_square", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool ImagePaddingSquare { get; set; }

        /// <summary>
        /// The name of a catalog given by the creator.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Name { get; set; }

        /// <summary>
        /// The total number of products in a catalog.
        /// </summary>
        [DeserializeAs(Name = "product_count")]
        [JsonProperty(PropertyName = "product_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ProductCount { get; set; }

        /// <summary>
        /// Number of items that don't have any quality issues. Quality issues are issues that affect the accuracy, freshness or completeness of the data in a catalog.
        /// </summary>
        [DeserializeAs(Name = "qualified_product_count")]
        [JsonProperty(PropertyName = "qualified_product_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int QualifiedProductCount { get; set; }

        /// <summary>
        /// The type of catalog
        /// </summary>
        [DeserializeAs(Name = "vertical")]
        [JsonProperty(PropertyName = "vertical", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Vertical { get; set; }
    }
}