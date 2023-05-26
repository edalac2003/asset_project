using asset_project.API.Data;
using asset_project.API.Helpers.Interfaces;
using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Helpers.Implementations
{
    public class StatusTypeHelper : IStatusTypeHelper
    {
        private readonly DataContext _context;
        public StatusTypeHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<List<StatusType>> GetAllAsync()
        {
            return await _context.StatusTypes.ToListAsync();
        }

        public async Task<StatusType> GetByIdAsync(int id)
        {
            var StatusType = await _context.StatusTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (StatusType == null)
            {
                return null!;
            }
            return StatusType!;

        }
    }
}
