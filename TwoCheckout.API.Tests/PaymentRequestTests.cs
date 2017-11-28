using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TwoCheckout.API.Tests
{
    [TestClass]
    public class PaymentRequestTests : TestBase
    {
        [TestMethod]
        public async Task Create_Sale()
        {
            int merchantOrderId = new Random().Next(0, 9999);
            var result = await API.PaymentRequest.CreateSale(new Models.CreateSaleModel
            {
                Currency = "ZAR",
                MerchantOrderId = $"{merchantOrderId}",
                Token = Token,
                Total = "123.45",
                BillingAddress = new Models.BillingAddress
                {
                    Name = "Testing Tester",
                    AddressLine1 = "123 Test St",
                    City = "Columbus",
                    State = "Ohio",
                    ZipCode = "43123",
                    Country = "USA",
                    Email = "example@2co.com",
                    PhoneNumber = "5555555555"
                }
            });
        }
    }
}
