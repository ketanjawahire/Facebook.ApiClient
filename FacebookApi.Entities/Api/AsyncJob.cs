using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities.Api
{
    /// <summary>
    /// Represents async job
    /// </summary>
    public class AsyncJob : BaseEntity
    {
        /// <summary>
        /// Async job id
        /// </summary>
        [DeserializeAs(Name = "id")][JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// Ad account id
        /// </summary>
        [DeserializeAs(Name = "account_id")][JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AccountId { get; set; }

        /// <summary>
        /// Time ref
        /// </summary>
        [DeserializeAs(Name = "time_ref")][JsonProperty(PropertyName = "time_ref", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long TimeRef { get; set; }

        /// <summary>
        /// Time completed
        /// </summary>
        [DeserializeAs(Name = "time_completed")][JsonProperty(PropertyName = "time_completed", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long TimeCompleted { get; set; }

        /// <summary>
        /// Async status
        /// </summary>
        [DeserializeAs(Name = "async_status")][JsonProperty(PropertyName = "async_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AsyncStatus { get; set; }

        /// <summary>
        /// Async percent completion
        /// </summary>
        [DeserializeAs(Name = "async_percent_completion")][JsonProperty(PropertyName = "async_percent_completion", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int AsyncPercentCompletion { get; set; }
    }
}
