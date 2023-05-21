namespace asset_project.Shared.Entities
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }

        public DateTime? RegisterDate { get; set; } = null;

        public DateTime? ClousureDate { get; set; } = null!;

        public string? Justification { get; set; }

        public string? UserName { get; set; }

        public string? Notes { get; set; }

        public StatusType? StatusType { get; set; } = null!;

        public int StatusId { get; set; }

        public Asset? Asset { get; set; } = null!;

        public int AssetId { get; set; }
    }
}
