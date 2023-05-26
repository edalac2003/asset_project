using asset_project.Shared.Entities;

namespace asset_project.Shared.DTO
{
    public class AssetResponseDTO
    {

        public User? User { get; set; }

        public List<Asset>? assets { get; set; }
    }
}
