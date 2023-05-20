namespace asset_project.Shared.Entities
{
    public class AssetDetail
    {
        public long Id { get; set; }

        public Asset? Asset { get; set; } = null!;

        public long AssetId { get; set; }

        public Property? Property { get; set; } = null!;

        public long? PropertyId { get; set; }

        public string? Value { get; set; } = null!;
    }
}
