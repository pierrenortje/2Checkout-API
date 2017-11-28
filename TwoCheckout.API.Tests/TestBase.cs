using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoCheckout.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;
        #endregion

        #region Public Fields
        public const string SellerId = "[YOUR-SELLER-ID]";
        public const string PrivateKey = "[YOUR-PRIVATE-KEY]";

        public const string Token = "[TOKEN-GENERATED-FROM-GENERATETOKEN.HTML]";

        // Your user with Admin access to the API
        public const string Username = "[YOUR-USERNAME]";
        public const string Password = "[YOUR-PASSWORD]";
        #endregion

        #region Public Properties
        public ApiRequest API
        {
            get
            {
                return this.api;
            }
        }
        #endregion

        #region Public Methods
        [TestInitialize]
        public void Init()
        {
            this.api = new ApiRequest(SellerId, PrivateKey);
        }
        #endregion
    }
}
