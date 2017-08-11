using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.ApiEngine
{
    /// <summary>
    /// Page cursors
    /// </summary>
    public class Cursors
    {
        /// <summary>
        /// Cursor for previous page
        /// </summary>
        [DeserializeAs(Name = "before")]
        public string Before { get; set; }

        /// <summary>
        /// Cursor for next page
        /// </summary>
        [DeserializeAs(Name = "after")]
        public string After { get; set; }

    }
}
