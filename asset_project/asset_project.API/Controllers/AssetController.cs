using Microsoft.EntityFrameworkCore;
using asset_project.API.Data;
using Microsoft.AspNetCore.Mvc;
using asset_project.Shared.Entities;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/assetcontroller")]
    public class AssetController : ControllerBase
    {
        private readonly DataContext _context;

        public AssetController(DataContext context) 
        {
            _context = context;    
        }

        [HttpGet]

        public async Task<IActionResult> GetAsync()
        {
            var queryable = _context.Assets.AsQueryable();
            return Ok(await queryable.OrderBy(x => x.Code).ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult> PostAsync(Asset asset)
        {
            try
            {
                _context.Add(asset);
                await _context.SaveChangesAsync();
                return Ok(asset);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una categoría con el mismo nombre.");
                }
                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
