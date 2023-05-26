using asset_project.API.Data;
using asset_project.API.Helpers.Interfaces;
using asset_project.Shared.DTO;
using asset_project.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Helpers.Implementations
{
    public class AssetHelper : IAssetHelper
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public AssetHelper(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task<Asset> GetAssetByIdAsync(int assetId)
        {
            throw new NotImplementedException();
        }

        public async Task<AssetResponseDTO> GetAssetByUserAsync(string userId, string userName)
        {
            var user = await _userHelper.GetUserAsync(userName);
            if (user != null)
            {
                var querable = _context.Assets
                .Where(a => a.Responsible.Equals(userId))
                .ToListAsync();

                AssetResponseDTO response = new ()
                {
                    User = user,
                    assets = await querable
                };

                return response;
            }
            return null!;
        }

        public async Task<Asset> GetAssetDetailsAsync(int assetId)
        {
            var asset = await _context.Assets
                .Include(a => a.Category)
                .Include(a => a.AssetType)
                .Include(a => a.Details!)
                .ThenInclude(d => d.Property!)
                .FirstOrDefaultAsync(x => x.Id == assetId);

            return asset!;
        }
    }
}
