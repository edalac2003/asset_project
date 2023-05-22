namespace asset_project.Shared.Entities
{
    public class WorkOrder
    {
        public int Id { get; set; }

        public StatusType? StatusType { get; set; }

        public DateTime AssignmentDateTime { get; set; }

        public MaintenanceRequest? MaintenanceRequest { get; set; }

        public int MaintenanceRequestId { get; set; }

        public string? TechnicianAssigned { get; set; }

        public int TechnicianId { get; set;}
    }
}
