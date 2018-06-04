# [WIP] 2Checkout-API
https://www.2checkout.com/payment-api

With 2Checkout’s Payment API, buyers can place sales directly on your website, with no redirection to our checkout.
You can take credit card information with a simple HTML form, and use our 2co.js JavaScript library to convert the
credit card information into a secure token. The token can then be safely passed to your server so that you can submit
the transaction using our API.

## Examples:

```csharp
var api = new ApiRequest("[YOUR-SELLER-ID]", "[YOUR-PRIVATE-KEY]");
string token = "[TOKEN-GENERATED-FROM-GENERATETOKEN.HTML]";

int merchantOrderId = new Random().Next(0, 9999);
var result = await api.PaymentRequest.CreateSale(new Models.CreateSaleModel
{
    Currency = "ZAR",
    MerchantOrderId = $"{merchantOrderId}",
    Token = token,
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
```
