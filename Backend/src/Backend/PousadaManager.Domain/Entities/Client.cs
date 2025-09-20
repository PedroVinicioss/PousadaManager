namespace PousadaManager.Domain.Entities
{
    public class Client
    {
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public ICollection<ClientAddress> Addresses { get; set; }
        public ICollection<ClientStay> ClientStays { get; set; }
    }
}
