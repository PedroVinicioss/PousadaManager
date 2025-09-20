namespace PousadaManager.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsClosed { get; set; }

        public ICollection<Consumption> Consumptions { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
