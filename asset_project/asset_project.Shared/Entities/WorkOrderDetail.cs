namespace asset_project.Shared.Entities
{
    public class WorkOrderDetail
    {
        public int Id { get; set; }

        public WorkOrder? WorkOrder { get; set; }

        public int WorkOrderId { get; set; }

        public string? notes { get; set; }

        public DateTime ServiceDateTime { get; set; }

        public int AttendedBy { get; set; }
    }
}
