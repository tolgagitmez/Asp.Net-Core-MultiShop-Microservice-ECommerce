﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class RegisterController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public RegisterController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Index(CreateRegisterDto registerDto)
		{
			if (registerDto.Password == registerDto.ConfirmPassword)
			{
				var client = _httpClientFactory.CreateClient();
				var jsonData = JsonConvert.SerializeObject(registerDto);
				StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
				var responseMessage = await client.PostAsync("https://localhost:5001/api/Registers", stringContent);
				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "Login");
				}
			}
			
			return View();
		}
	}
}
