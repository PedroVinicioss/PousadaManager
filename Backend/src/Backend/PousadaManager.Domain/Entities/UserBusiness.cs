using PousadaManager.Domain.Enums;

namespace PousadaManager.Domain.Entities
{
    public class UserBusiness : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public UserRole Role { get; set; }
    }
}
