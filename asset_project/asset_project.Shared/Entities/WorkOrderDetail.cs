namespace asset_project.Shared.Entities
{
    public class WorkOrderDetail
    {
        public long Id { get; set; }

        public WorkOrder? WorkOrder { get; set; }

        public long WordOrderId { get; set; }

        public string? notes { get; set; }

        public DateTime ServiceDateTime { get; set; }

        public long AttendedBy { get; set; }
    }
}
