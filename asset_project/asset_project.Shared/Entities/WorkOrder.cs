namespace asset_project.Shared.Entities
{
    public class WorkOrder
    {
        public long Id { get; set; }

        public Asset? Asset { get; set; }

        public long AssetId { get; set; }

        public StatusType? StatusType { get; set; }

        public DateTime AssignmentDateTime { get; set; }

        public MaintenanceRequest? MaintenanceRequest { get; set; }

        public long MaintenanceRequestId { get; set; }

        public string? TechnicianAssigned { get; set; }

        public long TechnicianId { get; set;}
    }
}
