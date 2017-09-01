using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents leadgen form dependent conditional questions
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenFormDependentConditionalQuestion
    {
        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Field key
        /// </summary>
        [DeserializeAs(Name = "field_key")]
        public string FieldKey { get; set; }
    }
}