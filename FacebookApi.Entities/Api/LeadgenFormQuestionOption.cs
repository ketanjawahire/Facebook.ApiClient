using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents leadgen form question options
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenFormQuestionOption
    {
        /// <summary>
        /// Key
        /// </summary>
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}