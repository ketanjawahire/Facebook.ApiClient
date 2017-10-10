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
    public class AsyncJob
    {
        /// <summary>
        /// Async job id
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Ad account id
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Time ref
        /// </summary>
        [DeserializeAs(Name = "time_ref")]
        public long TimeRef { get; set; }

        /// <summary>
        /// Time completed
        /// </summary>
        [DeserializeAs(Name = "time_completed")]
        public long TimeCompleted { get; set; }

        /// <summary>
        /// Async status
        /// </summary>
        [DeserializeAs(Name = "async_status")]
        public string AsyncStatus { get; set; }

        /// <summary>
        /// Async percent completion
        /// </summary>
        [DeserializeAs(Name = "async_percent_completion")]
        public int AsyncPercentCompletion { get; set; }
    }
}
