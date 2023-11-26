using Microsoft.AspNetCore.Mvc;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI.Controllers
{
    [ApiController]
    [Route("api/transaction_report/")]
    public class TransactionReportController : Controller
    {
        private readonly ITransactionReportService _transactionReportService;

        public TransactionReportController(ITransactionReportService transactionReportService)
        {
            _transactionReportService = transactionReportService;
        }

        [HttpGet("by_bank")]
        public async Task<IActionResult> GetByBankId([FromQuery] string bankId)
        {
            return Ok(await _transactionReportService.GetTransactionsByBank(bankId));
        }

        [HttpGet("by_date_range")]
        public async Task<IActionResult> GetByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            return Ok(await _transactionReportService.GetTransactionsByDateRange(startDate, endDate));
        }

        [HttpGet("by_order_reference")]
        public async Task<IActionResult> GetByOrderReference([FromQuery] string orderReference)
        {
            return Ok(await _transactionReportService.GetTransactionsByOrderReference(orderReference));
        }

        [HttpGet("by_status")]
        public async Task<IActionResult> GetByStatus([FromQuery] short status)
        {
            return Ok(await _transactionReportService.GetTransactionsByStatus(status));
        }
    }
}
