namespace asset_project.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public DateTime? InsertionDateTime { get; set; } = null!;

        public DateTime? UpdateDateTime { get; set; } = null!;

        public int Status { get; set; } = 0;

        public Person? Person { get; set; }

        public int PersonId { get; set; }
    }
}
