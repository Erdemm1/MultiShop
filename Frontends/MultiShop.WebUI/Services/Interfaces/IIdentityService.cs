using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Settings;

namespace MultiShop.WebUI.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInDto signInDto);
        Task<bool> GetRefreshToken();
    }
}
