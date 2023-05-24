using asset_project.API.Data;
using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Controllers
{
    public class MaintenanceRequestController
    {
        private readonly DataContext _context;

        public MaintenanceRequestController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAssets()
        {
            return getAssetByUserAsync();
        }

        private async Task<List<Asset>> getAssetByUserAsync(User user)
        {
            var querable = _context.Assets
                .Where(a => a.Responsible.Equals(user))
                .AsQueryable();

            return await querable.ToListAsync();    
        }
    }
}
