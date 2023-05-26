using asset_project.API.Helpers.Interfaces;
using asset_project.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetHelper _assetHelper;


        public AssetsController(IAssetHelper assetHelper)
        {
            _assetHelper = assetHelper;
        }

        [HttpGet("/getAssetDetails/{assetId}")]
        public async Task<IActionResult> GetAssetDetailsAsync(int assetId)
        {
            var asset = await _assetHelper.GetAssetDetailsAsync(assetId);
            if (asset == null)
            {
                return NotFound();
            }

            return Ok(asset);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAssetsByUserAsync([FromQuery] RequestDTO request)
        {
            return Ok(await _assetHelper.GetAssetByUserAsync(request.userId!, request.userName!));
        }
    }
}
