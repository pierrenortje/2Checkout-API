using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace TwoCheckout.API.Requests
{
    public class RequestBase
    {
        #region Protected Fields
        protected readonly IRestClient restClient;
        protected readonly string sellerId;
        protected readonly string privateKey;
        #endregion

        #region Constructor
        public RequestBase(IRestClient restClient, string sellerId, string privateKey)
        {
            this.restClient = restClient;
            this.sellerId = sellerId;
            this.privateKey = privateKey;
        }
        #endregion

        #region Public Properties
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        #endregion

        #region Protected Methods
        protected async Task<TResponseType> Execute<TResponseType>(IRestRequest request)
        {
            var response = await restClient.ExecuteTaskAsync<TResponseType>(request);

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;

            return JsonConvert.DeserializeObject<TResponseType>(response.Content);
        }
        #endregion
    }
}
