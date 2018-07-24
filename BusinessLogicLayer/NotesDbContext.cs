using DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer
{
	public class NoteListDbContext : DbContext
	{
		public DbSet<Note> Notes { get; set; }

		public NoteListDbContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NoteProjTrue;Username=postgres;Password=");
		}
	}
}
