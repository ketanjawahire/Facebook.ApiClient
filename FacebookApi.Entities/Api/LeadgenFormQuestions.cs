using System.Collections.Generic;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents leadgen form question
    /// <para>https://developers.facebook.com/docs/graph-api/reference/page/leadgen_forms/</para>
    /// </summary>
    public class LeadgenFormQuestions
    {
        /// <summary>
        /// form question key
        /// </summary>
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        /// <summary>
        /// form question label
        /// </summary>
        [DeserializeAs(Name = "label")]
        public string Label { get; set; }

        /// <summary>
        /// form question type
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// form question options
        /// </summary>
        [DeserializeAs(Name = "options")]
        public List<LeadgenFormQuestionOption> Options { get; set; }

        /// <summary>
        /// form conditional question
        /// </summary>
        [DeserializeAs(Name = "dependent_conditional_questions")]
        public List<LeadgenFormDependentConditionalQuestion> DependentConditionalQuestions { get; set; }

        /// <summary>
        /// form conditional question group id
        /// </summary>
        [DeserializeAs(Name = "conditional_questions_group_id")]
        public long? DependentConditionalQuestionGroupId { get; set; }
    }
}