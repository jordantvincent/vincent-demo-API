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

        // database tables
        // adding a DbSet of a model results in a table being created
        // in the database with the same name as the DbSet
        // ex: DbSet<CardModel> cards => 'cards' table

        public DbSet<TournamentModel> tournaments { get; set; }
        public DbSet<CardModel> cards { get; set; }

    }
}


