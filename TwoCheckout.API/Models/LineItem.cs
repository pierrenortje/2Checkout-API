using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwoCheckout.API.Models
{
    public class LineItem
    {
        /// <summary>
        /// The type of line item that is being passed in.
        /// (Always Lower Case, 'product', 'shipping', 'tax' or 'coupon', defaults to 'product') Required.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Name of the item passed in.
        /// (128 characters max, cannot use '&lt;' or '&gt;', defaults to capitalized version of 'type'.) Required.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Quantity of the item passed in. (0-999, defaults to 1 if not passed in or incorrectly formatted.) Optional.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Price of the line item. Format: 0.00-99999999.99, defaults to 0 if a
        /// value isn't passed in or if value is incorrectly formatted, no negatives
        /// (use positive values for coupons). Required.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Y or N. Will default to Y if the type is shipping. Optional.
        /// </summary>
        [JsonProperty("tangible")]
        public string Tangible { get; set; }

        /// <summary>
        /// Your custom product identifier. Optional.
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Sets billing frequency. Ex. '1 Week' to bill order once a week.
        /// (Can use # Week, # Month or # Year) Required for recurring lineitems.
        /// </summary>
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }

        /// <summary>
        /// Sets how long to continue billing. Ex. '1 Year'.
        /// (Forever or # Week, # Month, # Year) Required for recurring lineitems.
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Any start up fees for the product or service.
        /// Can be negative to provide discounted first installment pricing,
        /// but cannot equal or surpass the product price. Optional
        /// </summary>
        [JsonProperty("startupFee")]
        public string StartupFee { get; set; }

        /// <summary>
        /// Array of option objects using the attributes specified below. Optional
        /// Will be returned in the order that they are passed in. 
        /// (Passed as a sub object of a lineItem object.)
        /// </summary>
        [JsonProperty("options")]
        public List<LineItemOption> Options { get; set; }
    }
}
