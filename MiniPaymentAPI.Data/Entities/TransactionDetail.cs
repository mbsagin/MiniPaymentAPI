namespace MiniPaymentAPI.Data.Entities
{
    public class TransactionDetail
    {
        public string Id { get; set; }
        public string TransactionId { get; set; }
        public short TransactionType { get; set; }
        public short Status { get; set; }
        public decimal Amount { get; set; }

        public Transaction Transaction { get; set; }
    }
}
