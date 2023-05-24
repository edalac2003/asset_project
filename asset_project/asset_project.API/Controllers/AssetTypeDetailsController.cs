using Microsoft.EntityFrameworkCore;
using asset_project.API.Data;
using Microsoft.AspNetCore.Mvc;
using asset_project.Shared.Entities;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/assettypedetailscontroller")]
    public class AssetTypeDetailsController : ControllerBase
    {
        private readonly DataContext _context;

        public AssetTypeDetailsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAsync()
        {
            var queryable = _context.Properties.AsQueryable();

            return Ok(await queryable.OrderBy(x => x.Name).ToListAsync());

        }

        [HttpPost]

        public async Task<ActionResult> PostAsync(AssetTypeDetail assetTypeDetail)
        {
            _context.Add(assetTypeDetail);
            await _context.SaveChangesAsync();
            return Ok(assetTypeDetail);            

        }
    }
}
