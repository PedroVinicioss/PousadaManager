using PousadaManager.Domain.Enums;

namespace PousadaManager.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public string Description { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
    }
}
