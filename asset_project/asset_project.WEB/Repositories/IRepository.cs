namespace asset_project.WEB.Repositories
{
    public interface IRepository
    {
        //Task<HttpResponseWrapper<T>> Get<T>(string url);
        //Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        //Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
        //Task<HttpResponseWrapper<object>> Delete(string url);
        //Task<HttpResponseWrapper<object>> Put<T>(string url, T model);
        //Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);

        Task<HttpResponseWrapper<object>> GetAsync(string url);

        Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);

        Task<HttpResponseWrapper<TResponse>> PutAsync<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);
        
        Task<HttpResponseWrapper<object>> DeleteAsync(string url);
    }
}
