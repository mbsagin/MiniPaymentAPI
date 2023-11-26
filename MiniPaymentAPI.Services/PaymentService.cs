using MiniPaymentAPI.Data;
using MiniPaymentAPI.Data.Entities;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI.Services
{
    public class PaymentService
        : IPaymentService
    {
        private readonly IBankService _bankService;
        private readonly MiniPaymentAPIContext _dbContext;

        public PaymentService(
            IBankService bankService,
            MiniPaymentAPIContext dbContext)
        {
            _bankService = bankService;
            _dbContext = dbContext;
        }

        public async Task<Transaction> ProcessPayment(string bankId, decimal amount, string orderReference)
        {
            return await _bankService.Pay(new Transaction());
        }

        public async Task<TransactionDetail> ProcessCancellation(string transactionId)
        {
            return await _bankService.Cancel(transactionId);
        }

        public async Task<TransactionDetail> ProcessRefund(string transactionId)
        {
            return await _bankService.Refund(transactionId);
        }

    }
}
