using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace asset_project.API.Helpers.Interfaces
{
    public interface IStatusTypeHelper
    {
        Task<StatusType> GetByIdAsync(int id);

        Task<List<StatusType>> GetAllAsync();
    }
}
