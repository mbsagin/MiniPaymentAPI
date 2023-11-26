using MiniPaymentAPI.Services.Contracts;
using System.Transactions;

namespace MiniPaymentAPI.Services
{
    public class TransactionReportService
        : ITransactionReportService
    {
        public async Task<IEnumerable<Transaction>> GetTransactionsByBank(int bankId)
        {
            return Array.Empty<Transaction>();
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByStatus(TransactionStatus status)
        {
            return Array.Empty<Transaction>();
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByOrderReference(string orderReference)
        {
            return Array.Empty<Transaction>();
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return Array.Empty<Transaction>();
        }
    }
}
