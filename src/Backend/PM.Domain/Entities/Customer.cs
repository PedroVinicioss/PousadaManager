namespace PM.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public int BusinessId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? RG { get; set; }
        public string? CPF { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? District { get; set; }

        public bool IsSmoker { get; set; } = false;
        public string? Instagram { get; set; }
        public string? VehiclePlate { get; set; }
        public string? VehicleModel { get; set; }

        public string? HowDiscoveryHotel { get; set; }
    }
}