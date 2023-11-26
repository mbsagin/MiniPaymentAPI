using MiniPaymentAPI.Data.Entities;

namespace MiniPaymentAPI.Services.Contracts
{
    public interface IBankService
    {
        Task<TransactionDetail> Cancel(string transactionId);
        Task<Transaction> Pay(Transaction transaction);
        Task<TransactionDetail> Refund(string transactionId);
    }
}
