namespace PM.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid Uuid { get; set; } = Guid.NewGuid();
        public bool Active { get; set; } = true;
        public DateTime CreatOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdateOn { get; set; } = DateTime.UtcNow;
    }
}
