using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class FinancialAccount : BaseEntity
    {
        public int BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public new bool Active { get; set; } = true;

        public List<AccountFeeRule> FeeRules { get; set; } = [];

        public AccountFeeRule? FindRule(PaymentMethodType method)
            => FeeRules.FirstOrDefault(r => r.Method == method && r.Active);
    }
}
