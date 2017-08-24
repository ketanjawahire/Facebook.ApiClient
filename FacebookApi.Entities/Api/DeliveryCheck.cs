using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Delivery checks are a set of tests which can help find out potential issues related to ad delivery.
    /// <para>https://developers.facebook.com/docs/marketing-api/adgroup/deliverychecks/v2.5</para>
    /// </summary>
    public class DeliveryCheck
    {
        /// <summary>
        /// The name of the failed check 
        /// </summary>
        [DeserializeAs(Name = "check_name")]
        public string CheckName { get; set; }

        /// <summary>
        /// One line description of the error
        /// </summary>
        [DeserializeAs(Name = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// More detailed explanation of the error
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }
    }
}
