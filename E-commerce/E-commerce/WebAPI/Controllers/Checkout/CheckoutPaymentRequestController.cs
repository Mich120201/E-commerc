using Checkout;
using Checkout.Common;
using Checkout.Payments;
using Checkout.Payments.Request;
using Checkout.Payments.Request.Source;
using Checkout.Payments.Response;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using ecommerce.Models.CardDetailsInputModel;


namespace ecommerce.WebAPI.Controllers.Checkout
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutPaymentRequestController : Controller
    {
        private class RequestSource : AbstractRequestSource
        {
            public RequestSource(PaymentSourceType paymentSourceType): base(paymentSourceType) { }
        }
        private readonly ICheckoutApi _api;
        public CheckoutPaymentRequestController(ICheckoutApi api)
        {
            _api = api;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CardDetailsInputModel cardDetailsInputModel)
        {
            PaymentRequest paymentRequest = new PaymentRequest()
            {
                Source = new RequestCardSource
                {
                    Type = PaymentSourceType.Card,
                    Number = cardDetailsInputModel.CardNumber.Replace(" ", ""),
                    Cvv = cardDetailsInputModel.Cvv,
                    ExpiryMonth = int.Parse(cardDetailsInputModel.ExpiryDate.Split('/')[0]),
                    ExpiryYear = int.Parse(cardDetailsInputModel.ExpiryDate.Split('/')[1]),
                },
                Amount = cardDetailsInputModel.Amount,
                Currency = Currency.EUR,
                PaymentType = PaymentType.Regular,
                ProcessingChannelId = "pc_tagrwyahn2au7ebbcec5khd43e",
                Customer = new CustomerRequest
                {
                    Name = cardDetailsInputModel.Name + " " + cardDetailsInputModel.Surname
                }
            };
            PaymentResponse response = new PaymentResponse();
            try
            {
                response = await _api.PaymentsClient().RequestPayment(paymentRequest);
            }
            catch (CheckoutApiException e)
            {
                // API error
                IDictionary<string, object> errorDetails = e.ErrorDetails;
                return StatusCode(500, e.ErrorDetails.ToJson());
            }
            catch (CheckoutArgumentException e)
            {
                return StatusCode(500, e.ToJson());
            }
            if (response.HttpStatusCode != null)
            {
                return StatusCode(response.HttpStatusCode.Value, response.ToJson());
            }
            return StatusCode(500, response.ToJson());
        }
    }
}
