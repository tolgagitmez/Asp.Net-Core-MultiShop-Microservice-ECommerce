using MultiShop.DtoLayer.IdentityDtos;

namespace MultiShop.WebUI.Services.Interfaces
{
	public interface IIdentityService
	{
		Task<bool> SignIn(SignInDto signUpDto);
	}
}
