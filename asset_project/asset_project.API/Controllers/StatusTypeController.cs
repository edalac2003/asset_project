using asset_project.API.Helpers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusTypeController : ControllerBase
    {
        private readonly IStatusTypeHelper? _statusTypeHelper;

        public StatusTypeController(IStatusTypeHelper statusTypeHelper)
        {
            _statusTypeHelper = statusTypeHelper;
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _statusTypeHelper.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _statusTypeHelper.GetAllAsync());
        }
    }
}
