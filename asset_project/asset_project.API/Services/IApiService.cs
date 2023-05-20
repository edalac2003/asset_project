using Azure;

namespace asset_project.API.Services
{
    public interface IApiService
    {
        Task<Response<List<T>>> GetListAsync<T>(string servicePrefix, string controller);
    }
}
