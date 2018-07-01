using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public class NotesDbContext : DbContext
    {
		public DbSet<Note> Notes { get; set; }

		public NotesDbContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NotesApp;Trusted_Connection=True;");
		}
	}
}
