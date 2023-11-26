using MiniPaymentAPI.Data.Entities;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI.Services
{
    public class YapiKrediService
        : IBankService
    {
        public Task<TransactionDetail> Cancel(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> Pay(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDetail> Refund(Guid transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
