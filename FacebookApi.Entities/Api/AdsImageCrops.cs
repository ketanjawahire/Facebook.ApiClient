using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Image crops specification, in the format of [[{left},{top}],[{right},{bottom}]]
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ads-image-crops/</para>
    /// </summary>
    public class AdsImageCrops
    {
        /// <summary>
        /// Crop specification for 100x100
        /// </summary>
        [DeserializeAs(Name = "100x100")]
        public string _100x100 { get; set; }

        /// <summary>
        /// Crop specification for 100x72
        /// </summary>
        [DeserializeAs(Name = "100x72")]
        public string _100x72 { get; set; }

        /// <summary>
        /// Crop specification for 191x100
        /// </summary>
        [DeserializeAs(Name = "191x100")]
        public string _191x100 { get; set; }

        /// <summary>
        /// Crop specification for 400x150
        /// </summary>
        [DeserializeAs(Name = "400x150")]
        public string _400x150 { get; set; }


        /// <summary>
        /// Crop specification for 400x500
        /// </summary>
        [DeserializeAs(Name = "400x500")]
        public string _400x500 { get; set; }

        /// <summary>
        /// Crop specification for 600x360
        /// </summary>
        [DeserializeAs(Name = "600x360")]
        public string _600x360 { get; set; }

        /// <summary>
        /// Crop specification for 90x160
        /// </summary>
        [DeserializeAs(Name = "90x160")]
        public string _90x160 { get; set; }
    }
}
