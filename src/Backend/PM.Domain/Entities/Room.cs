namespace PM.Domain.Entities
{
    public class Room : BaseEntity
    {
        public int BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
