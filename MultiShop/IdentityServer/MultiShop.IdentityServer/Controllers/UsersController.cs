﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiShop.IdentityServer.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace MultiShop.IdentityServer.Controllers
{
	[Authorize(LocalApi.PolicyName)]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;

		public UsersController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet("GetUserInfo")]
		public async Task<IActionResult> GetUserInfo()
		{
			var userClaim = User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub);
			var user = await _userManager.FindByNameAsync(userClaim.Value);
			return Ok(new
			{
				Id = user.Id,
				Name = user.Name,
				Surname = user.Surname,
				Email = user.Email,
				UserName = user.UserName
			});
		}
	}
}
