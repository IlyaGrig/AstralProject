﻿using DataAccesLayer;
using Microsoft.EntityFrameworkCore;

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
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NoteProj;Username=postgres;Password=");
		}
	}
}
