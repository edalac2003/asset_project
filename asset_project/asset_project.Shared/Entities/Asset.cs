namespace asset_project.Shared.Entities
{
    public class Asset
    {
        public int Id { get; set; }

        public string Code { get; set; } = null!;

        public DateTime? PurchaseDate { get; set; }
        
        public double? PurchaseValue { get; set; }

        public int Status { get; set; } = 1;

        public Category Category { get; set; } = null!;

        public int CategoryId { get; set; }       

        public int UsefullLifetime { get; set; }

        public string Responsible { get; set; } = null!;

        public string Location { get; set; } = null!;

        public AssetType AssetType { get; set; } = null!;

        public int AssetTypeId { get; set; }

        public List<AssetDetail>? Details { get; set; }
    }
}
