using PM.Domain.Enums;

namespace PM.Domain.Entities
{
    public class Stay : BaseEntity
    {
        public int BusinessId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public StayStatusType Status { get; private set; } = StayStatusType.Pending;

        public List<StayGuest> Guests { get; set; } = [];
        public List<Receivable> Receivables { get; set; } = [];

        public decimal TotalOfDocuments() => Receivables.Sum(r => r.TotalAmount);
        public decimal PaidOnDocuments() => Receivables.Sum(r => r.Allocations.Sum(a => a.Amount));
        public decimal Balance() => TotalOfDocuments() - PaidOnDocuments();

        public void RecalculateStatus()
        {
            if (Balance() <= 0m && TotalOfDocuments() > 0m) { Status = StayStatusType.Paid; return; }
            if (PaidOnDocuments() > 0m && Balance() > 0m) { Status = StayStatusType.PartiallyPaid; return; }
            Status = StayStatusType.Pending;
        }
    }
}
