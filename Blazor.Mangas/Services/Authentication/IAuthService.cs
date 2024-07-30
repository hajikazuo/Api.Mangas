using Blazor.Mangas.Models;

namespace Blazor.Mangas.Services.Authentication
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel model);
        Task Logout();
    }
}
