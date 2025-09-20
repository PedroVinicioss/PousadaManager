namespace PousadaManager.Domain.Entities
{
    public class Stay : BaseEntity
    {
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal Amount { get; set; }

        public ICollection<ClientStay> ClientStays { get; set; }
    }

}
