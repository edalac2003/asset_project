namespace asset_project.Shared.Entities
{
    public class AssetTypeDetail
    {
        public int Id { get; set; }

        public Asset? Asset { get; set; }

        public int AssetId { get; set; }

        public Property? Property { get; set; }

        public int PropertyId { get; set; }

    }
}
