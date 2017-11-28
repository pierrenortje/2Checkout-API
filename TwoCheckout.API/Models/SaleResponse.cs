using RestSharp.Deserializers;
using System.Collections.Generic;

namespace TwoCheckout.API.Models
{
    public class SaleResponse
    {
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "currencyCode")]
        public string CurrencyCode { get; set; }

        [DeserializeAs(Name = "transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Array of lineitem objects using the attributes specified below. 
        /// Will be returned in the order that they are passed in. 
        /// (Passed as a sub object to the Authorization Object.) 
        /// (Only Use if you are not passing in total.)
        /// </summary>
        [DeserializeAs(Name = "lineItems")]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Object that defines the billing address using the attributes
        /// specified below. Required.
        /// (Passed as a sub object to the Authorization Object.) 
        /// </summary>
        [DeserializeAs(Name = "billingAddr")]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Object that defines the shipping address using the attributes
        /// specified below. Optional.
        /// Only required if a shipping lineitem is passed.
        /// (Passed as a sub object to the Authorization Object.)
        /// </summary>
        [DeserializeAs(Name = "shippingAddr")]
        public ShippingAddress ShippingAddress { get; set; }

        [DeserializeAs(Name = "merchantOrderId")]
        public string MerchantOrderId { get; set; }

        [DeserializeAs(Name = "orderNumber")]
        public string OrderNumber { get; set; }

        [DeserializeAs(Name = "recurrentInstallmentId")]
        public object RecurrentInstallmentId { get; set; }

        [DeserializeAs(Name = "responseMsg")]
        public string ResponseMsg { get; set; }

        [DeserializeAs(Name = "responseCode")]
        public string ResponseCode { get; set; }

        [DeserializeAs(Name = "total")]
        public string Total { get; set; }

        [DeserializeAs(Name = "errors")]
        public object Errors { get; set; }
    }
}
