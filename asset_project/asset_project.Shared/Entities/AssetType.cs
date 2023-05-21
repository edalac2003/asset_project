namespace asset_project.Shared.Entities
{
    public class AssetType
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public Property Property { get; set; } = null!;

        public int PropertyId { get; set; }
    }
}
