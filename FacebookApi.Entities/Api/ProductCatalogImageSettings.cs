using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Image transformation settings object to customize how items from the catalog would look like in different dynamic ad formats.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-catalog-image-settings/</para>
    /// </summary>
    public class ProductCatalogImageSettings : BaseEntity
    {
        /// <summary>
        /// Dynamic Ad display settings that would be applied to carousel ads.
        /// </summary>
        [DeserializeAs(Name = "carousel_ad")]
        [JsonProperty(PropertyName = "carousel_ad", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ProductCatalogImageSettingsOperation CarouselAd { get; set; }

        /// <summary>
        /// Dynamic Ad display settings that would be applied to single item ads.
        /// </summary>
        [DeserializeAs(Name = "single_ad")]
        [JsonProperty(PropertyName = "single_ad", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ProductCatalogImageSettingsOperation SingleAd { get; set; }
    }
}
