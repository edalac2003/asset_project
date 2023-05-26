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

        public MaintenanceRequestController(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] MaintenanceRequest maintenanceRequest)
        {
            //Buscar el Activo
            var Asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == maintenanceRequest.AssetId);
            if (Asset == null)
            {
                return BadRequest("El Activo fijo no se encuentra en la base de datos.");
            }

            //Buscar el Usuario
            var User = await _userHelper.GetUserAsync(maintenanceRequest.UserName!);
            if (User == null)
            {
                return BadRequest("El usuario no está vinculado a la base de datos.");
            }

            //Armar el Objeto a Guardar
            MaintenanceRequest MaintenanceRequest = new MaintenanceRequest()
            {
                RegisterDate = maintenanceRequest.RegisterDate,
                UserName = maintenanceRequest.UserName,
                Asset = Asset,
                Justification = maintenanceRequest.Justification,
                StatusId = ((int)StatusTypeEnum.REGISTRADA)
            };

            //Enviar la solicitud
            _context.Add(MaintenanceRequest);
            await _context.SaveChangesAsync();
            return Ok(MaintenanceRequest);
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

    }
}
