namespace asset_project.Shared.Entities
{
    public class AssetDetail
    {
        public int Id { get; set; }

        /*public Asset? Asset { get; set; }*/

        public int AssetId { get; set; }

        public Property? Property { get; set; }

        public int PropertyId { get; set; }

        public string? Value { get; set; } = null!;
    }
}
