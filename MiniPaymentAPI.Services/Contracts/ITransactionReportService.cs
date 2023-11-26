using System.Transactions;

namespace MiniPaymentAPI.Services.Contracts
{
    public interface ITransactionReportService
    {
        Task<IEnumerable<Transaction>> GetTransactionsByBank(string bankId);
        Task<IEnumerable<Transaction>> GetTransactionsByDateRange(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Transaction>> GetTransactionsByOrderReference(string orderReference);
        Task<IEnumerable<Transaction>> GetTransactionsByStatus(short status);
    }
}
