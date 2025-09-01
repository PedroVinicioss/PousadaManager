using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class User : BaseEntity
    {
        protected User() { }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public RoleType Role { get; set; } = RoleType.Customer;
        public List<Business> Businesses { get; set; } = [];
    }
}
