using MiniPaymentAPI.Data.Entities;

namespace MiniPaymentAPI.Services.Contracts
{
    public interface IPaymentService
    {
        Task<Transaction> ProcessPayment(string bankId, decimal amount, string orderReference);
        Task<TransactionDetail> ProcessCancellation(string transactionId);
        Task<TransactionDetail> ProcessRefund(string transactionId);
    }
}
