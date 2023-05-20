namespace asset_project.Shared.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public Asset? Asset { get; set; }

        public int Status { get; set; }
    }
}
