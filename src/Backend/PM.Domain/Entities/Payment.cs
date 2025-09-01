using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int BusinessId { get; set; }

        public int AccountId { get; set; }
        public FinancialAccount Account { get; set; } = null!;

        public PaymentMethodType Method { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Captured;

        public decimal GrossAmount { get; set; }   
        public decimal FeeAmount { get; set; }          
        public decimal NetAmount => GrossAmount - FeeAmount;

        public DateTime ReceivedAt { get; set; }

        public int? PayerCustomerId { get; set; }
        public string? PayerName { get; set; }
        public string? PayerDocument { get; set; }

        public List<PaymentAllocation> Allocations { get; set; } = [];
    }
}
