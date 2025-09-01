using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class StayGuest
    {
        public int StayId { get; set; }
        public Stay Stay { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public StayGuestRole Role { get; set; } = StayGuestRole.Acompanhante;
    }
}
