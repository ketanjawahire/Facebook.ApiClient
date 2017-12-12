using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Entities.Api;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A Product Set is a set of products in a Product Catalog that you advertise in a dynamic ad
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-set</para>
    /// </summary>
    public class ProductSet : BaseEntity
    {
        /// <summary>
        /// ID of the product set
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// URL scraped to create a product set
        /// </summary>
        [DeserializeAs(Name = "auto_creation_url")]
        [JsonProperty(PropertyName = "auto_creation_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AutoCreationUrl { get; set; }

        /// <summary>
        /// The filter rule that defines the set of products in the catalog
        /// </summary>
        [DeserializeAs(Name = "filter")]
        [JsonProperty(PropertyName = "filter", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Filter { get; set; }

        /// <summary>
        /// The name given by the owner of this product set
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Product catalog for this product set
        /// </summary>
        [DeserializeAs(Name = "product_catalog")]
        [JsonProperty(PropertyName = "product_catalog", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ProductCatalog ProductCatalog { get; set; }

        /// <summary>
        /// Count of products in this product set
        /// </summary>
        [DeserializeAs(Name = "product_count")]
        [JsonProperty(PropertyName = "product_count", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int ProductCount { get; set; }
    }
}
