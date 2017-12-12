using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Agency Client Declaration
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account/agency-client-declaration/</para>
    /// </summary>
    public class AgencyClientDeclaration : BaseEntity
    {
        /// <summary>
        /// Whether this account is for an agency representing a client
        /// </summary>
        [DeserializeAs(Name = "agency_representing_client")]
        [JsonProperty(PropertyName = "agency_representing_client", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int AgencyRepresentingClient { get; set; }

        /// <summary>
        /// Whether the client is based in France
        /// </summary>
        [DeserializeAs(Name = "client_based_in_france")]
        [JsonProperty(PropertyName = "client_based_in_france", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ClientBasedInFrance { get; set; }

        /// <summary>
        /// Client's city
        /// </summary>
        [DeserializeAs(Name = "client_city")]
        [JsonProperty(PropertyName = "client_city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientCity { get; set; }

        /// <summary>
        /// Client's country code
        /// </summary>
        [DeserializeAs(Name = "client_country_code")]
        [JsonProperty(PropertyName = "client_country_code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientCountryCode { get; set; }

        /// <summary>
        /// Client's email address
        /// </summary>
        [DeserializeAs(Name = "client_email_address")]
        [JsonProperty(PropertyName = "client_email_address", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// Name of the client
        /// </summary>
        [DeserializeAs(Name = "client_name")]
        [JsonProperty(PropertyName = "client_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float ClientName { get; set; }

        /// <summary>
        /// Client's postal code
        /// </summary>
        [DeserializeAs(Name = "client_postal_code")]
        [JsonProperty(PropertyName = "client_postal_code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientPostalCode { get; set; }

        /// <summary>
        /// Client's province
        /// </summary>
        [DeserializeAs(Name = "client_province")]
        [JsonProperty(PropertyName = "client_province", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientProvience { get; set; }

        /// <summary>
        /// First line of client's street address
        /// </summary>
        [DeserializeAs(Name = "client_street")]
        [JsonProperty(PropertyName = "client_street", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientStreet { get; set; }

        /// <summary>
        /// Second line of client's street address
        /// </summary>
        [DeserializeAs(Name = "client_street2")]
        [JsonProperty(PropertyName = "client_street2", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ClientStreet2 { get; set; }

        /// <summary>
        /// Whether the agency has a written mandate to advertise on behalf of this client
        /// </summary>
        [DeserializeAs(Name = "has_written_mandate_from_advertiser")]
        [JsonProperty(PropertyName = "has_written_mandate_from_advertiser", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int HasWrittenMandateFromAdvertiser { get; set; }

        /// <summary>
        /// Whether the client is paying via invoice
        /// </summary>
        [DeserializeAs(Name = "is_client_paying_invoices")]
        [JsonProperty(PropertyName = "is_client_paying_invoices", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int IsClientPayingInvoices { get; set; }
    }
}
