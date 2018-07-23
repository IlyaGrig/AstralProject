using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
	public class Repository : IRepository
	{
		public List<Note> NoteCollection { get; set; } = Note.GlobalNotes;
		public List<ApplicationUser> UserCollection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public static void DeleteFromCollection(int idNote)
		{
			int index = Note.GlobalNotes.IndexOf(Note.GlobalNotes.Find(e => e.IdNote == idNote));
			Note.GlobalNotes.RemoveAt(index);

		}

		public static Note UpdateCollection(int  idNote)
		{
			Note oldNote = Note.GlobalNotes.Find(e => e.IdNote == idNote);
			return oldNote;
		}

		public IEnumerable<Note> UpdateCollection(Note note)
		{
			throw new NotImplementedException();
		}

		IEnumerable<Note> IRepository.DeleteFromCollection(Note note)
		{
			throw new NotImplementedException();
		}
	}
}
