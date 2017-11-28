using RestSharp;
using System;
using System.Net;
using TwoCheckout.API.Requests;

namespace TwoCheckout.API
{
    public class ApiRequest
    {
        #region Private Fields
        private readonly IRestClient restClient;
        private readonly string sellerId;
        private readonly string privateKey;
        #endregion

        #region Constructor
        public ApiRequest(string sellerId, string privateKey)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            this.restClient = new RestClient
            {
#if DEBUG
                BaseUrl = new Uri("https://sandbox.2checkout.com/")
#else
                BaseUrl = new Uri("https://www.2checkout.com/")
#endif
            };

            this.sellerId = sellerId;
            this.privateKey = privateKey;
        }
        #endregion

        #region Public Properties
        public PaymentRequest PaymentRequest { get { return new PaymentRequest(this.restClient, this.sellerId, this.privateKey); } }
        #endregion
    }
}
