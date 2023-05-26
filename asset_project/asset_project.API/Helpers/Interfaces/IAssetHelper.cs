using asset_project.Shared.DTO;
using asset_project.Shared.Entities;

namespace asset_project.API.Helpers.Interfaces
{
    public interface IAssetHelper
    {
        Task<Asset> GetAssetByIdAsync(int assetId);

        Task<AssetResponseDTO> GetAssetByUserAsync(string userId, string userName);

        Task<Asset> GetAssetDetailsAsync(int assetId);
    }
}
