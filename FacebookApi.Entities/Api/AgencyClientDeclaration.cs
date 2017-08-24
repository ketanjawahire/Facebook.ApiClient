using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// Agency Client Declaration
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-account/agency-client-declaration/</para>
    /// </summary>
    public class AgencyClientDeclaration
    {
        /// <summary>
        /// Whether this account is for an agency representing a client
        /// </summary>
        [DeserializeAs(Name = "agency_representing_client")]
        public int AgencyRepresentingClient { get; set; }

        /// <summary>
        /// Whether the client is based in France
        /// </summary>
        [DeserializeAs(Name = "client_based_in_france")]
        public int ClientBasedInFrance { get; set; }

        /// <summary>
        /// Client's city
        /// </summary>
        [DeserializeAs(Name = "client_city")]
        public string ClientCity { get; set; }

        /// <summary>
        /// Client's country code
        /// </summary>
        [DeserializeAs(Name = "client_country_code")]
        public string ClientCountryCode { get; set; }

        /// <summary>
        /// Client's email address
        /// </summary>
        [DeserializeAs(Name = "client_email_address")]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// Name of the client
        /// </summary>
        [DeserializeAs(Name = "client_name")]
        public float ClientName { get; set; }

        /// <summary>
        /// Client's postal code
        /// </summary>
        [DeserializeAs(Name = "client_postal_code")]
        public string ClientPostalCode { get; set; }

        /// <summary>
        /// Client's province
        /// </summary>
        [DeserializeAs(Name = "client_province")]
        public string ClientProvience { get; set; }

        /// <summary>
        /// First line of client's street address
        /// </summary>
        [DeserializeAs(Name = "client_street")]
        public string ClientStreet { get; set; }

        /// <summary>
        /// Second line of client's street address
        /// </summary>
        [DeserializeAs(Name = "client_street2")]
        public string ClientStreet2 { get; set; }

        /// <summary>
        /// Whether the agency has a written mandate to advertise on behalf of this client
        /// </summary>
        [DeserializeAs(Name = "has_written_mandate_from_advertiser")]
        public int HasWrittenMandateFromAdvertiser { get; set; }

        /// <summary>
        /// Whether the client is paying via invoice
        /// </summary>
        [DeserializeAs(Name = "is_client_paying_invoices")]
        public int IsClientPayingInvoices { get; set; }
    }
}
