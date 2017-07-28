using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Use this field to customize the media for different Facebook placements. Currently you can use this field for customizing images only
    /// </summary>
    public class AdCreativePlatformCustomization
    {
        /// <summary>
        /// Media used on Instagram
        /// </summary>
        [DeserializeAs(Name = "instagram")]
        public AdCreativePlatformCustomizationOverride Instagram { get; set; }
    }
}
