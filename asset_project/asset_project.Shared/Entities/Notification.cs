namespace asset_project.Shared.Entities
{
    public class Notification
    {
        public long Id { get; set; }

        public string? Subject { get; set; } = null!;

        public string? Recipient { get; set; } = null!;

        public string Template { get; set; } = null!;

        public NotificationType NotificationType { get; set; } = null!;

        public int NotificationTypeId { get; set; }
    }
}
