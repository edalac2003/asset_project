namespace asset_project.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public State? State { get; set; }

        public int StateId { get; set; }
    }
}
