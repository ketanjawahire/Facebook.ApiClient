using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Display settings for a specific ad format.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-catalog-image-settings-operation/</para>
    /// </summary>
    public class ProductCatalogImageSettingsOperation : BaseEntity
    {
        /// <summary>
        /// The type of image transformation that would be applied to the image in a dynamic ad.
        /// </summary>
        [DeserializeAs(Name = "transformation_type")]
        [JsonProperty(PropertyName = "transformation_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TransformationType { get; set; }
    }
}
