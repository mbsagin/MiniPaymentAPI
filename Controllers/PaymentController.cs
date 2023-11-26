using Microsoft.AspNetCore.Mvc;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("pay")]
        public async Task<IActionResult> Pay([FromBody] string bankId, [FromBody] decimal amount, [FromBody] string orderReference)
        {
            return Ok(await _paymentService.ProcessPayment(bankId, amount, orderReference));
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> Cancel([FromQuery] string transactionId)
        {
            return Ok(await _paymentService.ProcessCancellation(transactionId));
        }

        [HttpPost("refund")]
        public async Task<IActionResult> Refund([FromQuery] string transactionId)
        {
            return Ok(await _paymentService.ProcessRefund(transactionId));
        }
    }
}
