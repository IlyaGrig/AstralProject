using System;
using System.Collections.Generic;
using DataAccesLayer;
using System.Linq;
using IconService;

namespace BusinessLogicLayer
{
	public class RepositoryService : IRepository, IDisposable
	{
		private NoteListDbContext db;

		public RepositoryService()
		{
			db = new NoteListDbContext();
		}

		public IEnumerable<Note> GetNoteList()
		{
			return db.Notes.ToList();
		}

		public void DeleteNote(int id)
		{
			Note note = db.Notes.First(e => e.NoteId == id);
			if (note != null)
				db.Notes.Remove(note);
			db.SaveChanges();
		}

		public void AddNote(string name, string header, string text, string userId)
		{
			Note newNote = new Note(userId, name, header, text);
			newNote.DateNote = DateTime.Now;
			newNote.Base64Icon = IconHelper.GetIconBase64();
			db.Notes.Add(newNote);
			db.SaveChanges();

		}

		public void UpdateNote(int id, string name, string header, string text)
		{
			Note note = db.Notes.First(e => e.NoteId == id);
			if (note != null)
			{
				db.Notes.Remove(note);
				note.NoteName = name; note.HeaderNote = header; note.TextNote = text;
				note.DateNote = DateTime.Now;
				db.Notes.Add(note);
			}
			db.SaveChanges();
		}

		public IEnumerable<Note> Search(string searchingText)
		{
			Search _search = new Search(db.Notes.ToList(), searchingText);
			return _search.GetNotesFound();
		}

		public Note GetNote (int id)
		{
			Note note = db.Notes.First(e => e.NoteId == id);
			if (note != null)
				return note;
			return null;
		}

		public void Dispose()
		{
			db.Dispose();
		}


	}
}
