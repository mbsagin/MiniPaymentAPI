namespace MiniPaymentAPI.Data.Entities
{
    public class Transaction
    {
        public Transaction()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public string Id { get; set; }
        public string BankId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public short Status { get; set; }
        public string OrderReference { get; set; }
        public DateTimeOffset TransactionDate { get; set; }

        public ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
