using System;
using System.Collections.Generic;
using FacebookApi.Interfaces;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A user represents a person on Facebook.
    /// <para>https://developers.facebook.com/docs/graph-api/reference/user/</para>
    /// </summary>
    public class User
    {
        /// <summary>
        /// The id of this person's user account. This ID is unique to each app and cannot be used across different apps.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// The About Me section of this person's profile
        /// </summary>
        [DeserializeAs(Name = "about")]
        public string About { get; set; }

        /// <summary>
        /// The age segment for this person expressed as a minimum and maximum age. For example, more than 18, less than 21.
        /// </summary>
        [DeserializeAs(Name = "age_range")]
        public string AgeRange { get; set; }

        /// <summary>
        /// The person's bio
        /// </summary>
        [DeserializeAs(Name = "bio")]
        public string Bio { get; set; }

        /// <summary>
        /// The person's birthday
        /// </summary>
        [DeserializeAs(Name = "birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// Social context for this person
        /// </summary>
        [DeserializeAs(Name = "context")]
        public string Context { get; set; }

        /// <summary>
        /// The person's cover photo
        /// </summary>
        [DeserializeAs(Name = "cover")]
        public string Cover { get; set; }

        /// <summary>
        /// The person's local currency information
        /// </summary>
        [DeserializeAs(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The list of devices the person is using. This will return only iOS and Android devices
        /// </summary>
        [DeserializeAs(Name = "devices")]
        public string Devices { get; set; }

        /// <summary>
        /// The person's education
        /// </summary>
        [DeserializeAs(Name = "education")]
        public string Education { get; set; }

        /// <summary>
        /// The person's primary email address listed on their profile. 
        /// </summary>
        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Athletes the person likes
        /// </summary>
        [DeserializeAs(Name = "favorite_athletes")]
        public string FavoriteAthlets { get; set; }

        /// <summary>
        /// Sports teams the person likes
        /// </summary>
        [DeserializeAs(Name = "favorite_teams")]
        public string FavoriteTeams { get; set; }

        /// <summary>
        /// The person's first name
        /// </summary>
        [DeserializeAs(Name = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The gender selected by this person, male or female. This value will be omitted if the gender is set to a custom value
        /// </summary>
        [DeserializeAs(Name = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The person's hometown
        /// </summary>
        [DeserializeAs(Name = "hometown")]
        public string Hometown { get; set; }

        /// <summary>
        /// The person's inspirational people
        /// </summary>
        [DeserializeAs(Name = "inspirational_people")]
        public string InspirationalPeople { get; set; }

        /// <summary>
        /// Install type
        /// </summary>
        [DeserializeAs(Name = "install_type")]
        public string InstallType { get; set; }

        /// <summary>
        /// Is the app making the request installed?
        /// </summary>
        [DeserializeAs(Name = "installed")]
        public bool IsInstalled { get; set; }

        /// <summary>
        /// Genders the person is interested in
        /// </summary>
        [DeserializeAs(Name = "interested_in")]
        public List<string> InterestedIn { get; set; }

        /// <summary>
        /// Is this a shared login (e.g. a gray user)
        /// </summary>
        [DeserializeAs(Name = "is_shared_login")]
        public bool IsSharedLogin { get; set; }

        /// <summary>
        /// This field indicates whether the person's profile is verified in this way. This is distinct from the verified field
        /// </summary>
        [DeserializeAs(Name = "is_verified")]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Facebook Pages representing the languages this person knows
        /// </summary>
        [DeserializeAs(Name = "languages")]
        public string Languages { get; set; }

        /// <summary>
        /// The person's last name
        /// </summary>
        [DeserializeAs(Name = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// A link to the person's Timeline
        /// </summary>
        [DeserializeAs(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// The person's locale
        /// </summary>
        [DeserializeAs(Name = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The person's current location as entered by them on their profile. This field is not related to check-ins
        /// </summary>
        [DeserializeAs(Name = "location")]
        public string Location { get; set; }

        /// <summary>
        /// What the person is interested in meeting for
        /// </summary>
        [DeserializeAs(Name = "meeting_for")]
        public List<string> MeetingFor { get; set; }

        /// <summary>
        /// The person's middle name
        /// </summary>
        [DeserializeAs(Name = "middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The person's full name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string FullName { get; set; }

        /// <summary>
        /// The person's name formatted to correctly handle Chinese, Japanese, or Korean ordering
        /// </summary>
        [DeserializeAs(Name = "name_format")]
        public string NameFormat { get; set; }

        /// <summary>
        /// The person's payment pricepoints
        /// </summary>
        [DeserializeAs(Name = "payment_pricepoints")]
        public string PaymentPricepoints { get; set; }

        /// <summary>
        /// The person's political views
        /// </summary>
        [DeserializeAs(Name = "political")]
        public string Political { get; set; }

        /// <summary>
        /// The person's PGP public key
        /// </summary>
        [DeserializeAs(Name = "public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// The person's favorite quotes
        /// </summary>
        [DeserializeAs(Name = "quotes")]
        public string Quotes { get; set; }

        /// <summary>
        /// The person's relationship status
        /// </summary>
        [DeserializeAs(Name = "relationship_status")]
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// The person's religion
        /// </summary>
        [DeserializeAs(Name = "religion")]
        public string Religion { get; set; }

        /// <summary>
        /// Security settings
        /// </summary>
        [DeserializeAs(Name = "security_settings")]
        public string SecuritySettings { get; set; }

        /// <summary>
        /// The time that the shared loginneeds to be upgraded to Business Manager by
        /// </summary>
        [DeserializeAs(Name = "shared_login_upgrade_required_by")]
        public string SharedLoginUpgradeRequiredBy { get; set; }

        /// <summary>
        /// The person's significant other
        /// </summary>
        [DeserializeAs(Name = "significant_other")]
        public string SignificantOther { get; set; }

        /// <summary>
        /// Sports played by the person
        /// </summary>
        [DeserializeAs(Name = "sports")]
        public string Sports { get; set; }

        /// <summary>
        /// Platform test group
        /// </summary>
        [DeserializeAs(Name = "test_group")]
        public int TestGroup { get; set; }

        /// <summary>
        /// A string containing an anonymous, but unique identifier for the person. You can use this identifier with third parties
        /// </summary>
        [DeserializeAs(Name = "third_party_id")]
        public string ThirdPartyId { get; set; }

        /// <summary>
        /// The person's current timezone offset from UTC
        /// </summary>
        [DeserializeAs(Name = "timezone")]
        public float Timezone { get; set; }

        /// <summary>
        /// A token that is the same across a business's apps.
        /// </summary>
        [DeserializeAs(Name = "token_for_business")]
        public string TokenForBusiness { get; set; }

        /// <summary>
        /// Updated time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Indicates whether the account has been verified. This is distinct from the is_verified field.
        /// </summary>
        [DeserializeAs(Name = "verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// Video upload limits
        /// </summary>
        [DeserializeAs(Name = "video_upload_limits")]
        public string VideoUploadLimits { get; set; }

        /// <summary>
        /// Can the viewer send a gift to this person?
        /// </summary>
        [DeserializeAs(Name = "viewer_can_send_gift")]
        public bool IsViewerCanSendGift { get; set; }

        /// <summary>
        /// The person's website
        /// </summary>
        [DeserializeAs(Name = "website")]
        public string Website { get; set; }

        /// <summary>
        /// Details of a person`s work experience
        /// </summary>
        [DeserializeAs(Name = "work")]
        public IList<WorkExperience> Work { get; set; }
    }
}
