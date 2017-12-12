using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents leadgen form question
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenFormQuestions : BaseEntity
    {
        /// <summary>
        /// form question key
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Key { get; set; }

        /// <summary>
        /// form question label
        /// </summary>
        [DeserializeAs(Name = "label")]
        [JsonProperty(PropertyName = "label", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Label { get; set; }

        /// <summary>
        /// form question type
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// form question options
        /// </summary>
        [DeserializeAs(Name = "options")]
        [JsonProperty(PropertyName = "options", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<LeadgenFormQuestionOption> Options { get; set; }

        /// <summary>
        /// form conditional question
        /// </summary>
        [DeserializeAs(Name = "dependent_conditional_questions")]
        [JsonProperty(PropertyName = "dependent_conditional_questions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<LeadgenFormDependentConditionalQuestion> DependentConditionalQuestions { get; set; }

        /// <summary>
        /// form conditional question group id
        /// </summary>
        [DeserializeAs(Name = "conditional_questions_group_id")]
        [JsonProperty(PropertyName = "conditional_questions_group_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? DependentConditionalQuestionGroupId { get; set; }
    }
}
