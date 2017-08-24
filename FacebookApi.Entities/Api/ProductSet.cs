using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// A Product Set is a set of products in a Product Catalog that you advertise in a dynamic ad
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/product-set</para>
    /// </summary>
    public class ProductSet
    {
        /// <summary>
        /// ID of the product set
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// URL scraped to create a product set
        /// </summary>
        [DeserializeAs(Name = "auto_creation_url")]
        public string AutoCreationUrl { get; set; }

        /// <summary>
        /// The filter rule that defines the set of products in the catalog
        /// </summary>
        [DeserializeAs(Name = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// The name given by the owner of this product set
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Product catalog for this product set
        /// </summary>
        [DeserializeAs(Name = "product_catalog")]
        public ProductCatalog ProductCatalog { get; set; }

        /// <summary>
        /// Count of products in this product set
        /// </summary>
        [DeserializeAs(Name = "product_count")]
        public int ProductCount { get; set; }
    }
}
