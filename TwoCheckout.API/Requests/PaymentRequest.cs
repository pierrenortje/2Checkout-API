using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using TwoCheckout.API.Interfaces;
using TwoCheckout.API.Models;

namespace TwoCheckout.API.Requests
{
    public class PaymentRequest : RequestBase, IPaymentRequest
    {
        public PaymentRequest(IRestClient restClient, string sellerId, string privateKey) : base(restClient, sellerId, privateKey) { }

        public async Task<SaleResponseBase> CreateSale(CreateSaleModel model)
        {
            model.SellerId = base.sellerId;
            model.PrivateKey = base.privateKey;

            var request = new RestRequest($"checkout/api/1/{base.sellerId}/rs/authService", Method.POST);
            var body = JsonConvert.SerializeObject(model, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            return await base.Execute<SaleResponseBase>(request);
        }
    }
}
