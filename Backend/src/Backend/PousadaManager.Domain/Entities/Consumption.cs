namespace PousadaManager.Domain.Entities
{
    public class Consumption : BaseEntity
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
