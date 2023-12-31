﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagment2.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required,MaxLength(100)]
		public string? FirstName { get; set; }

		[Required,MaxLength(100)]
		public string? LastName { get; set; }

		[Required,MaxLength(100)]
		public string? JobTitle { get; set; }

		public byte[]? ProfilePicture { get; set; }

	}
}
