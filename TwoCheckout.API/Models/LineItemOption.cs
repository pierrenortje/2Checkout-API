using Newtonsoft.Json;

namespace TwoCheckout.API.Models
{
    public class LineItemOption
    {
        /// <summary>
        /// Name of product option. Ex. Size (64 characters max – cannot include '&lt;' or '&gt;') Required
        /// </summary>
        [JsonProperty("optName")]
        public string Name { get; set; }

        /// <summary>
        /// Option selected. Ex. Small (64 characters max, cannot include '&lt;' or '&gt;') Required.
        /// </summary>
        [JsonProperty("optValue")]
        public string Value { get; set; }

        /// <summary>
        /// Option price in seller currency. (0.00 for no cost options) Required.
        /// </summary>
        [JsonProperty("optSurcharge")]
        public string Surcharge { get; set; }
    }
}
