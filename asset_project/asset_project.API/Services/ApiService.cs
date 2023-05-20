using Azure;

namespace asset_project.API.Services
{
    public class ApiService : IApiService
    {
        private readonly IConfiguration _configuration;

        public ApiService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<Response<List<T>>> GetListAsync<T>(string servicePrefix, string controller)
        {
            throw new NotImplementedException();
        }
    }
}
