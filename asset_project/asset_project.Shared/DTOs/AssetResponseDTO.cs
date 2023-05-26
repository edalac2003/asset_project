using asset_project.Shared.Entities;

namespace asset_project.Shared.DTOs
{
    public class AssetResponseDTO
    {

        public User? User { get; set; }

        public List<Asset>? assets { get; set; }
    }
}
