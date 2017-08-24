using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Display settings for a specific ad format.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-catalog-image-settings-operation/</para>
    /// </summary>
    public class ProductCatalogImageSettingsOperation
    {
        /// <summary>
        /// The type of image transformation that would be applied to the image in a dynamic ad.
        /// </summary>
        [DeserializeAs(Name = "transformation_type")]
        public string TransformationType { get; set; }
    }
}