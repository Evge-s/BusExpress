using BusExpress.Shared;
using BusExpress.Shared.Models.Accounts;

namespace BusExpress.Client.Services
{
    public interface IUserService
    {
        Task<IEnumerable<RegisterRequest>> GetAll();
        Task<WeatherForecast[]> GetAllF();
    }

    public class UserService : IUserService
    {
        private IHttpService _httpService;

        public UserService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<RegisterRequest>> GetAll()
        {
            return await _httpService.Get<IEnumerable<RegisterRequest>>("/users");
        }

        // test
        public async Task<WeatherForecast[]> GetAllF()
        {
            return await _httpService.Get<WeatherForecast[]>("/WeatherForecast");
        }

    }
}