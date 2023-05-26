using asset_project.Shared.Entities;

namespace asset_project.Shared.DTOs
{
    public class MaintenanceRequestDTO
    {
        public DateTime RegisterDate { get; set; }

        public string? UserName { get; set; }

        public string? UserId { get; set; }

        public int AssetId { get; set; }

        public string? Justification { get; set; }
    }
}
