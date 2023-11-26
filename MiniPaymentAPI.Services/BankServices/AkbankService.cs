using MiniPaymentAPI.Data.Entities;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI.Services
{
    public class AkbankService
        : IBankService
    {
        public Task<TransactionDetail> Cancel(string transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> Pay(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDetail> Refund(string transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
