using Newtonsoft.Json;

namespace TwoCheckout.API.Models
{
    public class BillingAddress
    {
        /// <summary>
        /// Card holder's name. (128 characters max) Required.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Card holder's street address. (64 characters max) Required.
        /// </summary>
        [JsonProperty("addrLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Card holder's street address line 2. (64 characters max)
        /// Required if “country” value is: CHN, JPN, RUS - Optional for all other “country” values.
        /// </summary>
        [JsonProperty("addrLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Card holder's city. (64 characters max) Required.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Card holder's state. (64 characters max)
        /// Required if “country” value is ARG, AUS, BGR, CAN, CHN, CYP, EGY, FRA, IND,
        /// IDN, ITA, JPN, MYS, MEX, NLD, PAN, PHL, POL, ROU, RUS, SRB, SGP, ZAF, ESP,
        /// SWE, THA, TUR, GBR, USA - Optional for all other “country” values.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Card holder's zip. (16 characters max)
        /// Required if “country” value is ARG, AUS, BGR, CAN, CHN, CYP, EGY, FRA, IND,
        /// IDN, ITA, JPN, MYS, MEX, NLD, PAN, PHL, POL, ROU, RUS, SRB, SGP, ZAF, ESP,
        /// SWE, THA, TUR, GBR, USA - Optional for all other “country” values.
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Card holder's country. (64 characters max) Optional.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Card holder's email. (64 characters max) Required.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Card holder's phone. (16 characters max) Required.
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Card holder's phone extension. (9 characters max) Optional.
        /// </summary>
        [JsonProperty("phoneExt")]
        public string PhoneExt { get; set; }
    }
}
