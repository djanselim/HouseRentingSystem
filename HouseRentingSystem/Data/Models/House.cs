using HouseRentingSystem.Data.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
	public class House
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(Constants.HouseTitleMaxLength)]
		public string Title { get; set; } = string.Empty;

		[Required]
		[MaxLength(Constants.HouseAddressMaxLength)]
		public string Address { get; set; } = string.Empty;

		[Required]
		[MaxLength(Constants.DescriptionMaxLength)]
		public string Description { get; set; } = string.Empty;

		[Required]
		public string ImageUrl { get; set; } = string.Empty;

		[Required]
		[Range(typeof(decimal), "0.00", "2000.0", ConvertValueInInvariantCulture = true)]
		public decimal PricePerMonth { get; set; }

		[Required]
		public int CategoryId { get; set; }

		public Category Category { get; set; } = null!;

		[Required]
		public int AgentId { get; set; }

		public Agent Agent { get; set; } = null!;

		public string RenderId { get; set; } = null!;
	}
}
