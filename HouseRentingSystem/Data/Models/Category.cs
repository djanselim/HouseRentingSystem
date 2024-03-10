using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Data.DataConstants;

namespace HouseRentingSystem.Data.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(Constants.CategoryNameMaxLength)]
		public string Name { get; set; }

		public ICollection<House> Houses = new List<House>();
	}
}
