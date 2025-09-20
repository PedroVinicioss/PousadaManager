namespace PousadaManager.Domain.Entities
{
    public class ClientAddress : BaseEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string District { get; set; }
        public string ResidentialNumber { get; set; }
    }
}
