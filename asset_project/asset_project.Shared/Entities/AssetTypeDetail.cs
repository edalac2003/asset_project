namespace asset_project.Shared.Entities
{
    public class AssetTypeDetail
    {
        public int Id { get; set; }

        public AssetType? AssetType { get; set; }

        public int AssetTypeId { get; set; }

        public Property? Property { get; set; }

        public int PropertyId { get; set; }

    }
}
