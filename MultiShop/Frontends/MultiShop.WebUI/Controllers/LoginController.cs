using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUI.Controllers
{
    public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ILoginService _loginService;
		private readonly IIdentityService _identityService;

		public LoginController(IHttpClientFactory httpClientFactory, ILoginService loginService, IIdentityService identityService)
		{
			_httpClientFactory = httpClientFactory;
			_loginService = loginService;
			_identityService = identityService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
		{

			
			return View();

		}

		
		public async Task<IActionResult> SignIn(SignInDto signInDto)
		{
			signInDto.Username = "ali01";
			signInDto.Password = "1111aA*";
			await _identityService.SignIn(signInDto);
			return RedirectToAction("Index", "User");
		}
	}
}
