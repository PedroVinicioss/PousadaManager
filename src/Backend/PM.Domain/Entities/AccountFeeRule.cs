using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class AccountFeeRule : BaseEntity
    {
        public int AccountId { get; set; }
        public PaymentMethodType Method { get; set; }
        public decimal Percent { get; set; }
        public decimal Fixed { get; set; }
        public new bool Active { get; set; } = true;

        public decimal CalcFee(decimal gross) => (gross * Percent) + Fixed;
    }
}
