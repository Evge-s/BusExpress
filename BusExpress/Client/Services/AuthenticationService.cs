using BusExpress.Shared.Models.Accounts;
using Microsoft.AspNetCore.Components;

namespace BusExpress.Client.Services
{
    public interface IAuthenticationService
    {
        AuthenticateResponse User { get; }
        Task Initialize();
        Task Login(AuthenticateRequest request);
        Task Register(RegisterRequest request);
        Task Logout();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public AuthenticateResponse User { get; private set; }

        public AuthenticationService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<AuthenticateResponse>("user");
        }

        public async Task Login(AuthenticateRequest request)
        {
            User = await _httpService.Post<AuthenticateResponse>("/accounts/authenticate", request);
            await _localStorageService.SetItem("user", User);
        }

        // temporary 
        public async Task Register(RegisterRequest request)
        {
            User = await _httpService.Post<AuthenticateResponse>("/accounts/register", request);
            await _localStorageService.SetItem("user", User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem("user");
            _navigationManager.NavigateTo("login");
        }
    }
}