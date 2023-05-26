using Microsoft.EntityFrameworkCore;
using asset_project.API.Data;
using Microsoft.AspNetCore.Mvc;
using asset_project.Shared.Entities;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/properties")]
    public class PropertiesController : ControllerBase
    {
        private readonly DataContext _context;

        public PropertiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAsync()
        {
            var queryable = _context.Properties.AsQueryable();

            return Ok(await queryable.OrderBy(x => x.Name).ToListAsync());
            
        }
    }
}
