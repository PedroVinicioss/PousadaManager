using PousadaManager.Domain.Enums;

namespace PousadaManager.Domain.Entities
{
    public class Business : BaseEntity
    {
        public string Name { get; set; }
        public BusinessType Type { get; set; }

        public ICollection<UserBusiness> UserBusinesses { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
        public ICollection<Stay> Stays { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
