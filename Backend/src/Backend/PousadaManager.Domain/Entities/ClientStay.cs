using PousadaManager.Domain.Enums;

namespace PousadaManager.Domain.Entities
{
    public class ClientStay : BaseEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int StayId { get; set; }
        public Stay Stay { get; set; }

        public ClientRole Role { get; set; }
    }
}
