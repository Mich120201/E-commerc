using System.Text.Json.Serialization;
using Checkout;
using Checkout.Payments.Request;
using Checkout.Payments.Response;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace ecommerce.WebAPI.Controllers.Checkout
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutPaymentRequestController : Controller
    {
        private readonly ICheckoutApi _api;
        public CheckoutPaymentRequestController(ICheckoutApi api)
        {
            _api = api;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PaymentRequest request)
        {
            PaymentResponse response = new PaymentResponse();
            try
            {
                response = await _api.PaymentsClient().RequestPayment(request);
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
