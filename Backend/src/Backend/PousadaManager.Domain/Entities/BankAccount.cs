namespace PousadaManager.Domain.Entities
{
    public class BankAccount : BaseEntity
    {
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public string Name { get; set; }
        public decimal PorcentageDiscount { get; set; }
        public decimal FixedDiscount { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
