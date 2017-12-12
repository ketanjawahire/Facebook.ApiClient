using System;
using System.Collections.Generic;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A user represents a person on Facebook.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/user/</para>
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// The id of this person's user account. This ID is unique to each app and cannot be used across different apps.
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long Id { get; set; }

        /// <summary>
        /// The About Me section of this person's profile
        /// </summary>
        [DeserializeAs(Name = "about")]
        [JsonProperty(PropertyName = "about", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string About { get; set; }

        /// <summary>
        /// The age segment for this person expressed as a minimum and maximum age. For example, more than 18, less than 21.
        /// </summary>
        [DeserializeAs(Name = "age_range")]
        [JsonProperty(PropertyName = "age_range", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AgeRange { get; set; }

        /// <summary>
        /// The person's bio
        /// </summary>
        [DeserializeAs(Name = "bio")]
        [JsonProperty(PropertyName = "bio", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Bio { get; set; }

        /// <summary>
        /// The person's birthday
        /// </summary>
        [DeserializeAs(Name = "birthday")]
        [JsonProperty(PropertyName = "birthday", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Birthday { get; set; }

        /// <summary>
        /// Social context for this person
        /// </summary>
        [DeserializeAs(Name = "context")]
        [JsonProperty(PropertyName = "context", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Context { get; set; }

        /// <summary>
        /// The person's cover photo
        /// </summary>
        [DeserializeAs(Name = "cover")]
        [JsonProperty(PropertyName = "cover", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Cover { get; set; }

        /// <summary>
        /// The person's local currency information
        /// </summary>
        [DeserializeAs(Name = "currency")]
        [JsonProperty(PropertyName = "currency", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Currency { get; set; }

        /// <summary>
        /// The list of devices the person is using. This will return only iOS and Android devices
        /// </summary>
        [DeserializeAs(Name = "devices")]
        [JsonProperty(PropertyName = "devices", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Devices { get; set; }

        /// <summary>
        /// The person's education
        /// </summary>
        [DeserializeAs(Name = "education")]
        [JsonProperty(PropertyName = "education", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Education { get; set; }

        /// <summary>
        /// The person's primary email address listed on their profile. 
        /// </summary>
        [DeserializeAs(Name = "email")]
        [JsonProperty(PropertyName = "email", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Email { get; set; }

        /// <summary>
        /// Athletes the person likes
        /// </summary>
        [DeserializeAs(Name = "favorite_athletes")]
        [JsonProperty(PropertyName = "favorite_athletes", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FavoriteAthlets { get; set; }

        /// <summary>
        /// Sports teams the person likes
        /// </summary>
        [DeserializeAs(Name = "favorite_teams")]
        [JsonProperty(PropertyName = "favorite_teams", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FavoriteTeams { get; set; }

        /// <summary>
        /// The person's first name
        /// </summary>
        [DeserializeAs(Name = "first_name")]
        [JsonProperty(PropertyName = "first_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FirstName { get; set; }

        /// <summary>
        /// The gender selected by this person, male or female. This value will be omitted if the gender is set to a custom value
        /// </summary>
        [DeserializeAs(Name = "gender")]
        [JsonProperty(PropertyName = "gender", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Gender { get; set; }

        /// <summary>
        /// The person's hometown
        /// </summary>
        [DeserializeAs(Name = "hometown")]
        [JsonProperty(PropertyName = "hometown", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Hometown { get; set; }

        /// <summary>
        /// The person's inspirational people
        /// </summary>
        [DeserializeAs(Name = "inspirational_people")]
        [JsonProperty(PropertyName = "inspirational_people", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InspirationalPeople { get; set; }

        /// <summary>
        /// Install type
        /// </summary>
        [DeserializeAs(Name = "install_type")]
        [JsonProperty(PropertyName = "install_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InstallType { get; set; }

        /// <summary>
        /// Is the app making the request installed?
        /// </summary>
        [DeserializeAs(Name = "installed")]
        [JsonProperty(PropertyName = "installed", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsInstalled { get; set; }

        /// <summary>
        /// Genders the person is interested in
        /// </summary>
        [DeserializeAs(Name = "interested_in")]
        [JsonProperty(PropertyName = "interested_in", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> InterestedIn { get; set; }

        /// <summary>
        /// Is this a shared login (e.g. a gray user)
        /// </summary>
        [DeserializeAs(Name = "is_shared_login")]
        [JsonProperty(PropertyName = "is_shared_login", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsSharedLogin { get; set; }

        /// <summary>
        /// This field indicates whether the person's profile is verified in this way. This is distinct from the verified field
        /// </summary>
        [DeserializeAs(Name = "is_verified")]
        [JsonProperty(PropertyName = "is_verified", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Facebook Pages representing the languages this person knows
        /// </summary>
        [DeserializeAs(Name = "languages")]
        [JsonProperty(PropertyName = "languages", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Languages { get; set; }

        /// <summary>
        /// The person's last name
        /// </summary>
        [DeserializeAs(Name = "last_name")]
        [JsonProperty(PropertyName = "last_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LastName { get; set; }

        /// <summary>
        /// A link to the person's Timeline
        /// </summary>
        [DeserializeAs(Name = "link")]
        [JsonProperty(PropertyName = "link", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Link { get; set; }

        /// <summary>
        /// The person's locale
        /// </summary>
        [DeserializeAs(Name = "locale")]
        [JsonProperty(PropertyName = "locale", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Locale { get; set; }

        /// <summary>
        /// The person's current location as entered by them on their profile. This field is not related to check-ins
        /// </summary>
        [DeserializeAs(Name = "location")]
        [JsonProperty(PropertyName = "location", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Location { get; set; }

        /// <summary>
        /// What the person is interested in meeting for
        /// </summary>
        [DeserializeAs(Name = "meeting_for")]
        [JsonProperty(PropertyName = "meeting_for", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> MeetingFor { get; set; }

        /// <summary>
        /// The person's middle name
        /// </summary>
        [DeserializeAs(Name = "middle_name")]
        [JsonProperty(PropertyName = "middle_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The person's full name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FullName { get; set; }

        /// <summary>
        /// The person's name formatted to correctly handle Chinese, Japanese, or Korean ordering
        /// </summary>
        [DeserializeAs(Name = "name_format")]
        [JsonProperty(PropertyName = "name_format", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string NameFormat { get; set; }

        /// <summary>
        /// The person's payment pricepoints
        /// </summary>
        [DeserializeAs(Name = "payment_pricepoints")]
        [JsonProperty(PropertyName = "payment_pricepoints", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PaymentPricepoints { get; set; }

        /// <summary>
        /// The person's political views
        /// </summary>
        [DeserializeAs(Name = "political")]
        [JsonProperty(PropertyName = "political", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Political { get; set; }

        /// <summary>
        /// The person's PGP public key
        /// </summary>
        [DeserializeAs(Name = "public_key")]
        [JsonProperty(PropertyName = "public_key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The person's favorite quotes
        /// </summary>
        [DeserializeAs(Name = "quotes")]
        [JsonProperty(PropertyName = "quotes", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Quotes { get; set; }

        /// <summary>
        /// The person's relationship status
        /// </summary>
        [DeserializeAs(Name = "relationship_status")]
        [JsonProperty(PropertyName = "relationship_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// The person's religion
        /// </summary>
        [DeserializeAs(Name = "religion")]
        [JsonProperty(PropertyName = "religion", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Religion { get; set; }

        /// <summary>
        /// Security settings
        /// </summary>
        [DeserializeAs(Name = "security_settings")]
        [JsonProperty(PropertyName = "security_settings", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SecuritySettings { get; set; }

        /// <summary>
        /// The time that the shared loginneeds to be upgraded to Business Manager by
        /// </summary>
        [DeserializeAs(Name = "shared_login_upgrade_required_by")]
        [JsonProperty(PropertyName = "shared_login_upgrade_required_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SharedLoginUpgradeRequiredBy { get; set; }

        /// <summary>
        /// The person's significant other
        /// </summary>
        [DeserializeAs(Name = "significant_other")]
        [JsonProperty(PropertyName = "significant_other", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string SignificantOther { get; set; }

        /// <summary>
        /// Sports played by the person
        /// </summary>
        [DeserializeAs(Name = "sports")]
        [JsonProperty(PropertyName = "sports", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Sports { get; set; }

        /// <summary>
        /// Platform test group
        /// </summary>
        [DeserializeAs(Name = "test_group")]
        [JsonProperty(PropertyName = "test_group", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int TestGroup { get; set; }

        /// <summary>
        /// A string containing an anonymous, but unique identifier for the person. You can use this identifier with third parties
        /// </summary>
        [DeserializeAs(Name = "third_party_id")]
        [JsonProperty(PropertyName = "third_party_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ThirdPartyId { get; set; }

        /// <summary>
        /// The person's current timezone offset from UTC
        /// </summary>
        [DeserializeAs(Name = "timezone")]
        [JsonProperty(PropertyName = "timezone", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public float Timezone { get; set; }

        /// <summary>
        /// A token that is the same across a business's apps.
        /// </summary>
        [DeserializeAs(Name = "token_for_business")]
        [JsonProperty(PropertyName = "token_for_business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TokenForBusiness { get; set; }

        /// <summary>
        /// Updated time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Indicates whether the account has been verified. This is distinct from the is_verified field.
        /// </summary>
        [DeserializeAs(Name = "verified")]
        [JsonProperty(PropertyName = "verified", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool Verified { get; set; }

        /// <summary>
        /// Video upload limits
        /// </summary>
        [DeserializeAs(Name = "video_upload_limits")]
        [JsonProperty(PropertyName = "video_upload_limits", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string VideoUploadLimits { get; set; }

        /// <summary>
        /// Can the viewer send a gift to this person?
        /// </summary>
        [DeserializeAs(Name = "viewer_can_send_gift")]
        [JsonProperty(PropertyName = "viewer_can_send_gift", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsViewerCanSendGift { get; set; }

        /// <summary>
        /// The person's website
        /// </summary>
        [DeserializeAs(Name = "website")]
        [JsonProperty(PropertyName = "website", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Website { get; set; }

        /// <summary>
        /// Details of a person`s work experience
        /// </summary>
        [DeserializeAs(Name = "work")]
        [JsonProperty(PropertyName = "work", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public IList<WorkExperience> Work { get; set; }
    }
}
