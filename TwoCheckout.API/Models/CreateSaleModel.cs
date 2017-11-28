using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwoCheckout.API.Models
{
    public class CreateSaleModel
    {
        /// <summary>
        /// Your 2Checkout account number. Required.
        /// </summary>
        [JsonProperty("sellerId")]
        internal string SellerId { get; set; }

        /// <summary>
        /// Your 2Checkout Private Key. Required.
        /// </summary>
        [JsonProperty("privateKey")]
        internal string PrivateKey { get; set; }

        /// <summary>
        /// Your custom order identifier. Required.
        /// </summary>
        [JsonProperty("merchantOrderId")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// The credit card token. Required.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Use to specify the currency for the sale. Required.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The Sale Total.
        /// Format: 0.00-99999999.99, defaults to 0 if a value isn't passed in or if
        /// value is incorrectly formatted, no negatives.
        /// (Only Use if you are not passing in lineItems.)
        /// </summary>
        [JsonProperty("total")]
        public string Total { get; set; }

        /// <summary>
        /// Array of lineitem objects using the attributes specified below. 
        /// Will be returned in the order that they are passed in. 
        /// (Passed as a sub object to the Authorization Object.) 
        /// (Only Use if you are not passing in total.)
        /// </summary>
        [JsonProperty("lineItems")]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Object that defines the billing address using the attributes
        /// specified below. Required.
        /// (Passed as a sub object to the Authorization Object.) 
        /// </summary>
        [JsonProperty("billingAddr")]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Object that defines the shipping address using the attributes
        /// specified below. Optional.
        /// Only required if a shipping lineitem is passed.
        /// (Passed as a sub object to the Authorization Object.)
        /// </summary>
        [JsonProperty("shippingAddr")]
        public ShippingAddress ShippingAddress { get; set; }
    }
}
