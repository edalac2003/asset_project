using asset_project.API.Data;
using asset_project.API.Helpers.Interfaces;
using asset_project.Shared.Entities;
using asset_project.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MaintenanceRequestController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly IStatusTypeHelper _statusTypeHelper;

        public MaintenanceRequestController(DataContext context, IUserHelper userHelper, IStatusTypeHelper statusTypeHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _statusTypeHelper = statusTypeHelper;

        }

        [HttpGet("[action]/{maintentanceId}")]
        public async Task<IActionResult> GetMaintenanceRequestByIdAsync(int maintentanceId = 0)
        {
            var maintenance = await _context.MaintenanceRequests
                .Include(m => m.Asset).ThenInclude(a => a.Details).ThenInclude(d => d.Property)
                .Include(m => m.Asset).ThenInclude(a => a.Category)
                .Include(m => m.Asset).ThenInclude(a => a.AssetType)
                .Include(m => m.StatusType)
                .FirstOrDefaultAsync(m => m.Id == maintentanceId);
            if (maintenance == null)
            {
                return NotFound();
            }

            return Ok(maintenance);

        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] MaintenanceRequest maintenanceRequest)
        {
            var Asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == maintenanceRequest.AssetId);
            if (Asset == null)
            {
                return BadRequest("El Activo fijo no se encuentra en la base de datos.");
            }

            var User = await _userHelper.GetUserAsync(maintenanceRequest.UserName!);
            if (User == null)
            {
                return BadRequest("El usuario no está vinculado a la base de datos.");
            }

            MaintenanceRequest MaintenanceRequest = new MaintenanceRequest()
            {
                RegisterDate = maintenanceRequest.RegisterDate,
                UserName = User.UserName,
                Asset = Asset,
                Justification = maintenanceRequest.Justification,
                StatusTypeId = ((int)StatusTypeEnum.REGISTRADA)
            };

            _context.Add(MaintenanceRequest);
            await _context.SaveChangesAsync();
            return Ok(MaintenanceRequest);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateMaintenanceRequest(MaintenanceRequest maintenanceRequest)
        {
            if (maintenanceRequest != null && maintenanceRequest.StatusTypeId > 0)
            {
                var statusType = await _statusTypeHelper.GetByIdAsync(maintenanceRequest.StatusTypeId);
                if(statusType == null)
                {
                    return NotFound("No existe el StatusType");

                }
                //maintenanceRequest.StatusTypeId = statusType; 
                maintenanceRequest.StatusType = (StatusType?)statusType;
                _context.Update(maintenanceRequest);
                try
                {
                    await _context.SaveChangesAsync();
                    return Ok(maintenanceRequest);

                }
                catch (DbUpdateException dbUpdateException)
                {
                    return BadRequest("Error: " + dbUpdateException.Message);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            else
            {
                return BadRequest("Debe ingresar un status");
            }

        }


        [HttpGet("[action]")]
        public async Task<List<MaintenanceRequest>> FindAll()
        {
            return await _context.MaintenanceRequests
                .Include(s => s.StatusType)
                .Include(x => x.Asset).ThenInclude(x => x.AssetType)
                .Include(m => m.Asset).ThenInclude(c => c.Category)
                .Include(a => a.Asset).ThenInclude(x => x.Details)
                .ToListAsync();
        }

        [HttpGet("[action]/{userName}")]
        public async Task<List<MaintenanceRequest>> FindAll(string userName)
        {
            return await _context.MaintenanceRequests
                .Include(s => s.StatusType)
                .Include(x => x.Asset).ThenInclude(x => x.AssetType)
                .Include(m => m.Asset).ThenInclude(c => c.Category)
                .Include(a => a.Asset).ThenInclude(x => x.Details)
                .Where(x => x.UserName == userName)
                .ToListAsync();
        }

    }
}
