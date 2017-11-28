using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;
using TwoCheckout.API.Interfaces;
using TwoCheckout.API.Models;

namespace TwoCheckout.API.Requests
{
    public class AdminRequest: RequestBase, IAdminRequest
    {
        public AdminRequest(IRestClient restClient, string sellerId, string privateKey) : base(restClient, sellerId, privateKey) { }

        public async Task<SaleResponseBase> RefundSale(RefundSaleModel model)
        {
            base.restClient.Authenticator = new HttpBasicAuthenticator(model.Username, model.Password);

            var request = new RestRequest("api/sales/refund_invoice", Method.POST);

            return await base.Execute<SaleResponseBase>(request);
        }
    }
}
