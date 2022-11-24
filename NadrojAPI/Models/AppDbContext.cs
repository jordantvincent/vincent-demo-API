using System;
using Microsoft.EntityFrameworkCore;

namespace NadrojAPI.Models
{
	public class AppDbContext : DbContext
	{
        //this is a test comment for a commit
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<TournamentModel> tournaments { get; set; }
		
    }
}


