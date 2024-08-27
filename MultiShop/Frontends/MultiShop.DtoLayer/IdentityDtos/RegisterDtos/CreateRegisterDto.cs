﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DtoLayer.IdentityDtos.RegisterDtos
{
	public class CreateRegisterDto
	{
		public string UserName { get; set; }
		public string UserEmail { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}
}
