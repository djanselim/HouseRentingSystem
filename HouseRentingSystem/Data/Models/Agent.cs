using HouseRentingSystem.Data.DataConstants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
	public class Agent
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(Constants.AgentPhoneNumberMaxLength)]
		public string PhoneNumber { get; set; } = string.Empty;

		[Required]
		public int UserId { get; set; }

		public IdentityUser User { get; set; } = null!;
	}
}
