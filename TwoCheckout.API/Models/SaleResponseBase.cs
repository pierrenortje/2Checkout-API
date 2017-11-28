using RestSharp.Deserializers;

namespace TwoCheckout.API.Models
{
    public class SaleResponseBase
    {
        [DeserializeAs(Name = "validationErrors")]
        public object ValidationErrors { get; set; }

        [DeserializeAs(Name = "response")]
        public SaleResponse Response { get; set; }

        [DeserializeAs(Name = "exception")]
        public object Exception { get; set; }
    }
}
