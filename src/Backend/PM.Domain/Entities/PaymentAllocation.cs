namespace PM.Domain.Entities
{
    public class PaymentAllocation : BaseEntity
    {
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = null!;

        public int ReceivableId { get; set; }
        public Receivable Receivable { get; set; } = null!;

        public decimal Amount { get; set; }
    }
}
