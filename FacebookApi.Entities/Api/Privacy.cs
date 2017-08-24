using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The Privacy node is returned as part of a number of different types of nodes as a privacy field.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/privacy/</para>
    /// </summary>
    public class Privacy
    {
        /// <summary>
        /// The IDs of the specific users or friend lists that can see the object (as a comma-separated string).
        /// </summary>
        [DeserializeAs(Name = "allow")]
        public string Allow { get; set; }

        /// <summary>
        /// The IDs of the specific users or friend lists that cannot see the object (as a comma-separate string)
        /// </summary>
        [DeserializeAs(Name = "deny")]
        public string Deny { get; set; }

        /// <summary>
        /// A description of the privacy settings. For custom settings, it can contain names of users, networks and friend lists.
        /// </summary>
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Which category of users can see the object. This field is only set when the 'value' field is CUSTOM.
        /// </summary>
        [DeserializeAs(Name = "friends")]
        public string Friends { get; set; }

        /// <summary>
        /// The ID of the network that can see the object, or 1 for all of the user's networks.
        /// </summary>
        [DeserializeAs(Name = "networks")]
        public string Networks { get; set; }

        /// <summary>
        /// The privacy value for the object.
        /// </summary>
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}
