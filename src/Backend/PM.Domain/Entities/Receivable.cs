using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class Receivable : BaseEntity
    {
        public int BusinessId { get; set; }
        public int? StayId { get; set; }                
        public ReceivableType Type { get; set; }
        public string Label { get; set; } = string.Empty;   
        public DateTime OccurredOn { get; set; }

        public decimal TotalAmount { get; private set; }
        public decimal Balance { get; private set; }     
        public bool Closed { get; private set; }

        public List<PaymentAllocation> Allocations { get; set; } = [];

        public void Increase(decimal amount)
        {
            if (amount <= 0m) throw new InvalidOperationException("Valor inválido.");
            TotalAmount += amount;
            Balance += amount;
        }

        public void ApplyAllocation(PaymentAllocation alloc)
        {
            if (Closed) throw new InvalidOperationException("Documento fechado.");
            if (alloc.Amount <= 0m) throw new InvalidOperationException("Alocação inválida.");
            if (alloc.Amount > Balance + 0.01m) throw new InvalidOperationException("Alocação excede o saldo.");

            Allocations.Add(alloc);
            Balance -= alloc.Amount;

            if (Balance <= 0.0001m)
            {
                Balance = 0m;
                Closed = true;
            }
        }
    }
}
