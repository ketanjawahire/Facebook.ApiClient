using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    public enum CreativeType
    {
        /// <summary>
        /// Page
        /// </summary>
        PAGE,

        /// <summary>
        /// Domain
        /// </summary>
        DOMAIN,

        /// <summary>
        /// Event
        /// </summary>
        EVENT,

        /// <summary>
        ///  refers to an iTunes or Google Play store destination
        /// </summary>
        STORE_ITEM,

        /// <summary>
        /// Offer
        /// </summary>
        OFFER,

        /// <summary>
        /// Share from a page
        /// </summary>
        SHARE,

        /// <summary>
        /// Photo
        /// </summary>
        PHOTO,

        /// <summary>
        /// status of a page
        /// </summary>
        STATUS,

        /// <summary>
        /// VIdeo
        /// </summary>
        VIDEO,

        /// <summary>
        /// app on Facebook
        /// </summary>
        APPLICATION,

        /// <summary>
        /// when an invalid object_id was specified such as a deleted object or if you do not have permission to see the object. In very few cases, this field may be empty if Facebook is unable to identify the type of advertised object
        /// </summary>
        INVALID
    }
}
