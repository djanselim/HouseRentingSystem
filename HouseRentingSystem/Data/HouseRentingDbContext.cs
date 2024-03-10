using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HouseRentingSystem.Data
{
	public class HouseRentingDbContext : IdentityDbContext
	{
		public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
			: base(options)
		{
			
		}

		public DbSet<House> Houses { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Agent> Agents { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder
				.Entity<House>()
				.HasOne(h => h.Category)
				.WithMany(c => c.Houses)
				.HasForeignKey(h => h.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<House>()
				.HasOne(h => h.Agent)
				.WithMany()
				.HasForeignKey(h => h.AgentId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}