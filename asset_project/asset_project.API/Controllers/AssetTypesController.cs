

using asset_project.API.Data;
using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/assettipyescontroller")]
    public class AssetTypesController: ControllerBase
    {
        private readonly DataContext _context;

        public AssetTypesController(DataContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync() 
        { 
            var queryable = _context.AssetTypes.AsQueryable();
            return Ok(await queryable.OrderBy(x => x.Name).ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult> PostAsync(AssetType assetType)
        {
            try
            {
                _context.Add(assetType);                
                await _context.SaveChangesAsync();
                return Ok(assetType);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un tipo activo con el mismo nombre.");
                }
                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]

        public async Task<ActionResult> PutAsync(AssetType assetType)
        {
            try
            {
                _context.Update(assetType);
                await _context.SaveChangesAsync();
                return Ok(assetType);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un tipo activo con el mismo nombre.");
                }
                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var assetType = await _context.AssetTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (assetType == null)
            {
                return NotFound();
            }
            _context.Remove(assetType);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
